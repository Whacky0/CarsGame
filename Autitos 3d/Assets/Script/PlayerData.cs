using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float points;

    public PlayerData (saves seconds)
    {
        points = seconds.points;
    }
}
