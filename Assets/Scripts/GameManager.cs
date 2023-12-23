using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool hasPlayed;

    private void Awake () { instance = this; }



    public void SaveGameBtn () 
    {
        PlayerData data = Serializer.LoadProgress();
        if (data == null)
        {
            hasPlayed = false;
        }
        else
        {
            hasPlayed = true;
        }
        Serializer.SavePlayer(this);
    }



    public void LoadGameBtn () 
    { 
        PlayerData data = Serializer.LoadProgress();

        if (data == null)
        {
            hasPlayed = false;
        }
        else
        {
            hasPlayed = data.hasPlayed;
        }
    }
}
