using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStreets : MonoBehaviour
{
    float time=0;
    // Update is called once per frame
    void Update()
    {
        if (time<=360)
        {
            time += Time.deltaTime;
            gameObject.transform.eulerAngles = new Vector3(0, time, 0);
        }
        else
        {
            time = 0;
            gameObject.transform.eulerAngles = new Vector3(0, time, 0);

        }
    }
}
