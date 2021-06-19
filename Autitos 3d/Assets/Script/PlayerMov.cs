using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public static bool velocityUP;
    Ray posTouch;
    int Ur = 0;
    int Ul = 0;
    int Dr = 0;
    int Dl = 0;
    int mov;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            posTouch = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(posTouch, out raycastHit))
            {
                if (raycastHit.collider.name == "StreetZ+")
                {
                    velocityUP = true;
                    mov = 1;
                }
                else if (raycastHit.collider.name == "StreetZ-")
                {
                    velocityUP = true;
                    mov = 2;
                }
                else if (raycastHit.collider.name == "StreetX+")
                {
                    velocityUP = true;
                    mov = 3;

                }
                else if (raycastHit.collider.name == "StreetX-")
                {
                    velocityUP = true;
                    mov = 4;

                }

            }
            }

        carMov();
          

    }

    void carMov()
    {
        if (velocityUP)
        {
            if (mov == 1) { 

                var rb = CarsManager.RightUp[Ur].GetComponent<Rigidbody>();
                rb.AddForce(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 5);
                Debug.Log(CarsManager.RightUp[Ur].transform.position);
                velocityUP = false;
                Ur++;
                mov = 0;
                //z-
            }

           else if (mov == 2)
            {

                var rb = CarsManager.leftUp[Ul].GetComponent<Rigidbody>();
                    rb.AddForce(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 5);
                Debug.Log(CarsManager.RightUp[Ur].transform.position);
                velocityUP = false;
                    Ul++;
                mov = 0;
                    //z+
            }

           else if (mov == 3) { 
                    var rb = CarsManager.RightDown[Dr].GetComponent<Rigidbody>();
                    rb.AddForce(gameObject.transform.position.x - 5, gameObject.transform.position.y, gameObject.transform.position.z);
                    velocityUP = false;
                    Dr++;
                mov = 0;
                //x-
            }
           else if (mov == 4) { 

                    var rb = CarsManager.leftDown[Dl].GetComponent<Rigidbody>();
                    rb.AddForce(gameObject.transform.position.x + 5, gameObject.transform.position.y, gameObject.transform.position.z);
                    velocityUP = false;
                    Dl++;
                mov = 0;
                //x+
            }
            }
        }
    }

