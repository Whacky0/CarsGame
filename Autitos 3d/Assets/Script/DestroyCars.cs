using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCars : MonoBehaviour
{
   
    void Update()
    {
        var car = GameObject.FindGameObjectsWithTag("Car");
        foreach (var carPos in car)
        {
            if (carPos.transform.position.y < -5)
            {
                Destroy(carPos);
            }
        }
    }
}
