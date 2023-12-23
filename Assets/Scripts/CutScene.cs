using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public static bool hasPlayed;
    private float startTime;

    void Start()
    {
        Application.targetFrameRate = 240;
        startTime = Time.time;
    }

    void Update()
    {
        // Check timer and transition to GameScene after 5 seconds
        if (Time.time - startTime >= 5f)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
