using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject optionPanel;
    public AudioManager audioManager;

    [Header("Transitions")]
    public Animator fadeInBlack;
    public Animator fadeOutBlack;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pause()
    {
        if (pausePanel.activeSelf)
        {
             Time.timeScale = 1;
             pausePanel.SetActive(false);
        }
        else if (optionPanel.activeSelf)
        {
            optionPanel.SetActive(false);
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 0;
            optionPanel.SetActive(false);
            pausePanel.SetActive(true);
        }
        audioManager.Lowpass();
    }

    public void Option()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);
        optionPanel.SetActive(!optionPanel.activeSelf);
    }

    public void SceneTransitionIn(float time)
    {
        fadeInBlack.enabled = true;
        fadeInBlack.speed = 1.0f / time;
    }

    public void SceneTransitionOut(float time)
    {
        fadeOutBlack.enabled = true;
        fadeOutBlack.speed = 1.0f / time;
    }
}
