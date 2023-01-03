using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject cameraFollow;

    // Update is called once per frame
    void Update()
    {
        if(EventsOnStart.IsStarted == true)
        {
            // use the p key to pause the game
            if (Keyboard.current.escapeKey.wasPressedThisFrame)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void Resume()
    {
        // disable the mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
        // enable the camera follow gameObject
        cameraFollow.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        // enable the mouse cursor
        Cursor.lockState = CursorLockMode.None;
        // disable the camera follow gameObject
        cameraFollow.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
