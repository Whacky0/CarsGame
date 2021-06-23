using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStreets : MonoBehaviour
{

   public static float time=0;
    // Update is called once per frame

    void Update()
    {
        
        if (time<=360)
        {
            time += Time.deltaTime;
            gameObject.transform.eulerAngles = new Vector3(0, time, 0);
            Debug.Log(time);
        }
        else
        {
            time = 0;
            gameObject.transform.eulerAngles = new Vector3(0, time, 0);

        }
        
       
    }
}
