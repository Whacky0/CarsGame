using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saves : MonoBehaviour
{
    public static saves instantiate;
    public float points;
    public static bool Lost;

    private void Awake()
    {
        if (instantiate == null)
        {
            instantiate= this;
            DontDestroyOnLoad(this);
        }
        else 
        {
            Destroy(gameObject);
        }
    }



    private void Update()
    {
        points = TimeManager.seconds;
        if (Load.LastHighScore<points) { 
            savePoints();
        }

    }
    public void savePoints()
    {
        SavePoints.SavePlayerPoints(this);
    }
}
