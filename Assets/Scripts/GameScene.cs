using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        Application.targetFrameRate = 240;
        gameManager = GameManager.instance;
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.S))
        {
            gameManager.SaveGameBtn();
            Debug.Log("La save vayo!");
        }

        // Check for "Esc" key press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnPauseButtonPress();
        }
    }

    public void OnPauseButtonPress()
    {
        // Load the pause menu scene asynchronously
        SceneManager.LoadSceneAsync("PauseMenu");

        // Disable game input and pause time
        Time.timeScale = 0f;
        //Input.enabled = false;
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        // Unpause the game if focus is lost and the pause menu is active
        if (!hasFocus && SceneManager.GetSceneByName("PauseMenu").isLoaded)
        {
            Time.timeScale = 1f;
            SceneManager.UnloadSceneAsync("PauseMenu");
        }
    }
}
