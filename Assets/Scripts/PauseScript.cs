using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public static bool pauseActive = false;
    public static bool settingsSaved = false;
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject controlsMenuUI;
    public GameObject videoMenuUI;
    void Update()
    {
        //when escape key is pressed, will either pause or unpause the game
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
        //unpauses the game
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pauseActive = false;
    }
    void Pause()
    {
        //pauses the game
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pauseActive = true;
    }
    public void LoadMenu()
    {
        //loads main menu
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    public void OpenSettings()
    {
        //opens settings menu within the pause menu
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }
    public void Back()
    {
        //save settings goes here
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
        //opens the control settings within the pause menu
        settingsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(true);
    }
    public void OpenVideo()
    {
        //opens the video settings within the pause menu
        settingsMenuUI.SetActive(false);
        videoMenuUI.SetActive(true);
    }
}
