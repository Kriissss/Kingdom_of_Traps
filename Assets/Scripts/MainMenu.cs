using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                playGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    public void playGame()
    {
        isPaused = false;
        SceneManager.LoadScene("Cutscene");
        //Time.timeScale = 1.0f;
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void pauseGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenu");
        isPaused = true;
        //Time.timeScale = 0.0f;
    }
}