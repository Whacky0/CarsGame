using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCars : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        var cars = GameObject.FindGameObjectsWithTag("Car");
        foreach (var car in cars)
        {
            if (car.transform.position.y <= 7.7f)
            {
                Destroy(car);
            }
        }
        
    }
}
