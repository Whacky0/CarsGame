using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cont;
    public GameObject menuPause;
    bool dark = false;
    float seconds=50;
    float r = 0.5433428f;
    float b = 0.6981132f;
    float g = 0.6981132f;
    // Update is called once per frame
    void Update()
    {
        if (cont.activeInHierarchy == false && menuPause.activeInHierarchy == false) { 
            seconds -= Time.deltaTime;
        if (!dark) { 
        if (seconds >=0  && b >= 0.1886792f)
        {
            Debug.Log(seconds);
            r = r - 0.0001f;
            g = g - 0.0001f;
            b = b - 0.0001f;
            Camera.main.backgroundColor = new Color(r, g, b);
            Debug.Log(r + g + b);

        }
        else
        {
            seconds = 50;
            dark = true;

        }
        }
        else
        {
            if (seconds >= 0 && b <= 0.6981132f)
            {
                Debug.Log(seconds);
                r = r + 0.0001f;
                g = g + 0.0001f;
                b = b + 0.0001f;
                Camera.main.backgroundColor = new Color(r, g, b);
                Debug.Log(r + g + b);

            }
            else
            {
                seconds = 50;
                dark = false;

            }

        }
    }
    }
}
