using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player
{
    public int level;
    public string height;
    public Vector3 position;
}

public class GameManager : MonoBehaviour
{
    [Header("Managers")]
    public GUIManager guiManager;
    public AudioManager audioManager;

    [Space]
    public bool pause;

    [Header("Scenes")]
    public float transitionTime = 1;
    public List<string> gameScenes;

    private Transform playerPosition;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;

        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        guiManager.SceneTransitionOut(transitionTime);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        guiManager.SceneTransitionOut(transitionTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        guiManager.Pause();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextScene()
    {
        int index = gameScenes.FindIndex(n => n == SceneManager.GetActiveScene().name);

        if (index == -1)
        {
            Debug.Log("Scene not in game manager: " + SceneManager.GetActiveScene().name);
            return;
        }

        if (index == gameScenes.Count)
        {
            Debug.Log("Already at the last scene!");
            return;
        }

        guiManager.SceneTransitionIn(transitionTime);

        SceneManager.LoadScene(gameScenes[index + 1]);
    }
}
