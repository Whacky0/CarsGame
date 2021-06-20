using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool velocityUP;
    Ray posTouch;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posTouch = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(posTouch, out raycastHit))
            {

                if (raycastHit.collider.tag == "Car")
                {
                    raycastHit.transform.GetComponent<instantiateCars>().cont++;

                }
            }
        }



    }
}


    