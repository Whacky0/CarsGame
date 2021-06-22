using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileRotations : MonoBehaviour
{
   public static ViewPortHandler.Constraint cons;
    private void Update()
    {
        if(Input.deviceOrientation == DeviceOrientation.Portrait)
        {
            cons = ViewPortHandler.Constraint.Portrait; 
        }
        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            cons = ViewPortHandler.Constraint.Landscape;
        }
    }
}
