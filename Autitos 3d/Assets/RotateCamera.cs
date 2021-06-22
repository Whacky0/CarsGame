using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform target;
    public static Vector3 rot;
    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(target);
        rot = Vector3.right * Time.deltaTime;
        transform.Translate(Vector3.right * Time.deltaTime/2.5f);

        
    }

}

