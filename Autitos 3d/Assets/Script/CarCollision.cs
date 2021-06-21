using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    private void Awake()
    {
        saves.Lost = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            saves.Lost = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
