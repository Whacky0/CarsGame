using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateCars : MonoBehaviour
{
   public int mov;
    public int cont=0;
    public bool PressedOnce = false;
    public bool PressedTwice = false;
    bool normalSpeed = false;
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Trigger")
        {
            Debug.Log("entro a trigger");
            normalSpeed = true;
        }
        else
        {
            normalSpeed = false;
        }
    }


    private void Awake()
    {
        switch (CarsManager.randPos)
        {
            case 1:
                mov = 1;
                //z-
                break;
            case 2:
                mov = 2;
                //z+
                break;
            case 3:
                mov = 3;
                //x-
                break;
            case 4:
                mov = 4;
                //x+
                break;
        }
    }

    private void Update()
    {
        if (cont % 2 != 0 &&!normalSpeed)
        {
            switch (mov)
            {
                case 1:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.3f);
                    //z-
                    break;
                case 2:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 0.3f);
                    //z+
                    break;
                case 3:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.3f, gameObject.transform.position.y, gameObject.transform.position.z);
                    //x-
                    break;
                case 4:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y, gameObject.transform.position.z);
                    //x+
                    break;
            }

        }
        else if ( cont % 2 == 0 && cont != 0 &&!normalSpeed)
        {
            switch (mov)
            {
                case 1:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.1f);
                    //z-
                    break;
                case 2:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 0.1f);
                    //z+
                    break;
                case 3:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
                    //x-
                    break;
                case 4:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
                    //x+
                    break;
            }

        }
        else if (cont==0 || normalSpeed) {

            switch (mov)
            {
                case 1:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.1f);
                    //z-
                    break;
                case 2:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 0.1f);
                    //z+
                    break;
                case 3:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
                    //x-
                    break;
                case 4:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
                    //x+
                    break;

            }
        } 
    }
    
    }
    



