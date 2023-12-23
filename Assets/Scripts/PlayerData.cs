using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData
{
    public bool hasPlayed;

    public PlayerData(GameManager gameProgress)
    {
        hasPlayed = gameProgress.hasPlayed;
    }
}
