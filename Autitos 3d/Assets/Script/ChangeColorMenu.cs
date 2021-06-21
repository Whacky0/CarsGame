using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorMenu : MonoBehaviour
{
    // Start is called before the first frame update
    bool dark = false;
    float seconds = 50;
    float r = 0.3940904f;
    float b = 0.6792453f;
    float g = 0.6792453f;
    // Update is called once per frame
    void Update()
    {

        seconds -= Time.deltaTime;
        if (!dark)
        {
            if (seconds >= 0 && b >= 0.1792453f)
            {
                r = r - 0.001f;
                g = g - 0.001f;
                b = b - 0.001f;
                Camera.main.backgroundColor = new Color(r, g, b);

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
                r = r + 0.001f;
                g = g + 0.001f;
                b = b + 0.001f;
                Camera.main.backgroundColor = new Color(r, g, b);

            }
            else
            {
                seconds = 50;
                dark = false;

            }

        }
    }
}
