using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseTrigger : MonoBehaviour
{
    public static bool pauseActive = false;
    public static bool settingsSaved = false;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject controlsMenuUI;
    public GameObject videoMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pauseActive = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pauseActive = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    public void OpenSettings()
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }
    public void Back()
    {
        //save settings
        if (settingsMenuUI.activeSelf)
        {
            settingsMenuUI.SetActive(false);
            pauseMenuUI.SetActive(true);
        }
        if (controlsMenuUI.activeSelf)
        {
            controlsMenuUI.SetActive(false);
            settingsMenuUI.SetActive(true);
        }
        if (videoMenuUI.activeSelf)
        {
            videoMenuUI.SetActive(false);
            settingsMenuUI.SetActive(true);
        }
    }
    public void OpenControls()
    {
        settingsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(true);
    }
    public void OpenVideo()
    {
        settingsMenuUI.SetActive(false);
        videoMenuUI.SetActive(true);
    }
}
