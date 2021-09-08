using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPause : MonoBehaviour
{
    public bool isPaused;
    public GameObject pausePanel;
    void Start()
    {
        Time.timeScale = 1f;
        isPaused = false;
        pausePanel.SetActive(isPaused);
    }

    public void PauseScreen(){
            isPaused = true;
            Time.timeScale = 0f;
            pausePanel.SetActive(isPaused);
    }
    public void Play(){
            isPaused = false;
            Time.timeScale = 1f;
            pausePanel.SetActive(isPaused);
    }
}
