using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioMixer masterMixer;
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterLvl(float masterLvl)
    {
        masterMixer.SetFloat("Master Volume", masterLvl);
    }

    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("Music Volume", musicLvl);
    }
    public void SetSFXLvl(float sfxLvl)
    {
        masterMixer.SetFloat("SFX Volume", sfxLvl);
    }

    public void Lowpass()
    {
        if (Time.timeScale == 0)
        {
            paused.TransitionTo(.01f);
        }
        else
        {
            unpaused.TransitionTo(.01f);
        }
    }
}
