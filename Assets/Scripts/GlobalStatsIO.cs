using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class GlobalStatsIO
{
    [Serializable]
    public class StatisticValues
    {
        public string key = null;
        public string value = "0";
        public string sorting = null;
        public string rank = "0";
        public string value_change = "0";
        public string rank_change = "0";
    }

    [Serializable]
    public class LinkData
    {
        public string url = null;
        public string pin = null;
    }

    [Serializable]
    public class AdditionalData
    {
        public string key;
        public string value;
        public string rank;
    }

    [Serializable]
    public class LeaderboardValue
    {
        public string name = null;
        public string user_profile = null;
        public string user_icon = null;
        public string rank = "0";
        public string value = "0";

        public AdditionalData[] additionals;
    }

    [Serializable]
    public class Leaderboard
    {
        public LeaderboardValue[] data;
    }

    private readonly string _apiId;
    private readonly string _apiSecret;
    private AccessToken _apiAccessToken;
    private List<StatisticValues> _statisticValues = new List<StatisticValues>();

    [HideInInspector]
    public string statisticId = "";

    [HideInInspector]
    public string userName = "";

    [HideInInspector]
    public LinkData linkData = null;

    [Serializable]
    private class AccessToken
    {
        public string access_token = null;
        public string token_type = null;
        public string expires_in = null;
        public int created_at = (int) DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        //Check if still valid, allow a 2 minute grace period
        public bool IsValid() =>
            (this.created_at + int.Parse(this.expires_in) - 120) > (int) DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }

    [Serializable]
    private class StatisticResponse
    {
        public string name = null;
        public string _id = null;

        [SerializeField]
        public List<StatisticValues> values = null;
    }

    public GlobalStatsIO(string apiKey, string apiSecret)
    {
        this._apiId = apiKey;
        this._apiSecret = apiSecret;
    }

    private IEnumerator GetAccessToken()
    {
        string url = "https://api.globalstats.io/oauth/access_token";

        WWWForm form = new WWWForm();
        form.AddField("grant_type", "client_credentials");
        form.AddField("scope", "endpoint_client");
        form.AddField("client_id", this._apiId);
        form.AddField("client_secret", this._apiSecret);

        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();

            string responseBody = www.downloadHandler.text;

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogWarning("Error retrieving access token: " + www.error);
                Debug.Log("GlobalstatsIO API Response: " + responseBody);
                yield break;
            }
            else
            {
                this._apiAccessToken = JsonUtility.FromJson<AccessToken>(responseBody);
            }
        }
    }

    public IEnumerator AddLeaderboardEntry(Dictionary<string, string> values, string id = "", string name = "", Action<bool> callback = null)
    {
        bool update = false;

        if (this._apiAccessToken == null || !this._apiAccessToken.IsValid())
        {
            yield return this.GetAccessToken();
        }

        // If no id is supplied but we have one stored, reuse it.
        if (id == "" && this.statisticId != "")
        {
            id = this.statisticId;
        }

        string url = "https://api.globalstats.io/v1/statistics";
        if (id != "")
        {
            url = "https://api.globalstats.io/v1/statistics/" + id;
            update = true;
        }
        else
        {
            if (name == "")
            {
                name = "anonymous";
            }
        }

        string jsonPayload;

        if (update == false)
        {
            jsonPayload = "{\"name\":\"" + name + "\", \"values\":{";
        }
        else
        {
            jsonPayload = "{\"values\":{";
        }

        bool semicolon = false;
        foreach (KeyValuePair<string, string> value in values)
        {
            if (semicolon)
            {
                jsonPayload += ",";
            }

            jsonPayload += "\"" + value.Key + "\":\"" + value.Value + "\"";
            semicolon = true;
        }
        jsonPayload += "}}";

        byte[] pData = Encoding.UTF8.GetBytes(jsonPayload);
        StatisticResponse statistic = null;

        using (UnityWebRequest www = new UnityWebRequest(url))
        {
            if (update == false)
            {
                www.method = "POST";
            }
            else
            {
                www.method = "PUT";
            }

            www.uploadHandler = new UploadHandlerRaw(pData);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Authorization", "Bearer " + this._apiAccessToken.access_token);
            www.SetRequestHeader("Content-Type", "application/json");
            yield return www.SendWebRequest();

            string responseBody = www.downloadHandler.text;

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogWarning("Error submitting statistic: " + www.error);
                Debug.Log("GlobalstatsIO API Response: " + responseBody);
                callback?.Invoke(false);
            }
            else
            {
                statistic = JsonUtility.FromJson<StatisticResponse>(responseBody);
            }
        };

        // ID is available only on create, not on update, so do not overwrite it
        if (statistic._id != null && statistic._id != "")
        {
            this.statisticId = statistic._id;
        }

        this.userName = statistic.name;

        //Store the returned data statically
        foreach (StatisticValues value in statistic.values)
        {
            bool updatedExisting = false;
            for (int i = 0; i < this._statisticValues.Count; i++)
            {
                if (this._statisticValues[i].key == value.key)
                {
                    this._statisticValues[i] = value;
                    updatedExisting = true;
                    break;
                }
            }
            if (!updatedExisting)
            {
                this._statisticValues.Add(value);
            }
        }

        callback?.Invoke(true);
    }

    public StatisticValues GetStatistic(string key)
    {
        for (int i = 0; i < this._statisticValues.Count; i++)
        {
            if (this._statisticValues[i].key == key)
            {
                return this._statisticValues[i];
            }
        }
        return null;
    }

    public IEnumerator LinkStatistic(string id = "", Action<bool> callback = null)
    {
        if (this._apiAccessToken == null || !this._apiAccessToken.IsValid())
        {
            yield return this.GetAccessToken();
        }

        // If no id is supplied but we have one stored, reuse it.
        if (id == "" && this.statisticId != "")
        {
            id = this.statisticId;
        }

        string url = "https://api.globalstats.io/v1/statisticlinks/" + id + "/request";

        string jsonPayload = "{}";
        byte[] pData = Encoding.UTF8.GetBytes(jsonPayload);

        using (UnityWebRequest www = new UnityWebRequest(url, "POST")
        {
            uploadHandler = new UploadHandlerRaw(pData),
            downloadHandler = new DownloadHandlerBuffer()
        })
        {
            www.SetRequestHeader("Authorization", "Bearer " + this._apiAccessToken.access_token);
            www.SetRequestHeader("Content-Type", "application/json");
            yield return www.SendWebRequest();

            string responseBody = www.downloadHandler.text;

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogWarning("Error linking statistic: " + www.error);
                Debug.Log("GlobalstatsIO API Response: " + responseBody);
                callback?.Invoke(false);
            }

            this.linkData = JsonUtility.FromJson<LinkData>(responseBody);
        };

        callback?.Invoke(true);
    }

    [Serializable]
    struct GetLeaderBoardRequest
    {
        public int limit;
        public string[] additionals;
    }

    public IEnumerator GetLeaderboard(string key, Action<Leaderboard> callback, int resultCountLimit = 100, string[] additionalKeys = default)
    {
        resultCountLimit = Mathf.Clamp(resultCountLimit, 0, 100); // make sure resultCountLimit is between 0 and 100

        if (this._apiAccessToken == null || !this._apiAccessToken.IsValid())
        {
            yield return this.GetAccessToken();
        }

        var requestData = new GetLeaderBoardRequest{ limit = resultCountLimit, additionals = additionalKeys };

        string url = "https://api.globalstats.io/v1/gtdleaderboard/" + key;

        // string json_payload = "{\"limit\":" + resultCountLimit + ", \"additionals\": [\"seed\"]" + "\n}";
        byte[] pData = Encoding.UTF8.GetBytes(JsonUtility.ToJson(requestData));

        Leaderboard leaderboard = null;
        using (UnityWebRequest www = new UnityWebRequest(url, "POST")
        {
            uploadHandler = new UploadHandlerRaw(pData),
            downloadHandler = new DownloadHandlerBuffer()
        })
        {
            www.SetRequestHeader("Authorization", "Bearer " + this._apiAccessToken.access_token);
            www.SetRequestHeader("Content-Type", "application/json");
            yield return www.SendWebRequest();

            string responseBody = www.downloadHandler.text;

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogWarning("Error getting leaderboard: " + www.error);
                Debug.Log("GlobalstatsIO API Response: " + responseBody);
                callback?.Invoke(null);
            }
            else
            {
                leaderboard = JsonUtility.FromJson<Leaderboard>(responseBody);
            }
        };

        callback?.Invoke(leaderboard);
    }
}