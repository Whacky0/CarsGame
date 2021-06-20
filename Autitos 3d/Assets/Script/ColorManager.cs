using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Material blue;
    public Material Red;
    public GameObject car;
    private void Update()
    {
        if(instantiateCars.colorBlue)
        {
            car.GetComponent<MeshRenderer>().material = blue;
        }
        if (instantiateCars.colorRed)
        {
            car.GetComponent<MeshRenderer>().material = Red;

        }
    }
}
