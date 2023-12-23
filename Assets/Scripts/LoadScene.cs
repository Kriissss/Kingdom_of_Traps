using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    private GameManager gameManager;
    public bool hasPlayed;
    private float startTime;
    

    void Start()
    {
        startTime = Time.time;
        gameManager = GameManager.instance;
        gameManager.SaveGameBtn();
        PlayerData data = Serializer.LoadProgress();
        hasPlayed = data.hasPlayed;
        Debug.Log(data.hasPlayed.ToString());
    }

    
    void Update()
    {
        if (Time.time - startTime >= 0.03f)
        {
            if (hasPlayed == false)
            {
                SceneManager.LoadScene("CutScene");
                gameManager.SaveGameBtn();
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        else
        {
            Debug.Log("ke ho khai");
        }
    }
}
