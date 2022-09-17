using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    bool isPaused = false;
    public GameObject resumeUI;

    private void Start()
    {
        resumeUI.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("quit game");
    }

    
    public void PauseGame()
    {
        if (!isPaused)
        {
            resumeUI.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
    }

    public void ResumeGame()
    {
        if (isPaused)
        {
            resumeUI.SetActive(false);
            Time.timeScale = 1.0f;
            isPaused = false;
        }

    }


}
