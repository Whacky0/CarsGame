using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            Debug.Log("Toco");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
