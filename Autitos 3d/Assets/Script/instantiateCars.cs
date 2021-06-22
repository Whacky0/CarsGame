using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateCars : MonoBehaviour
{
   public int mov;
    public  int cont=0;
   public  bool normalSpeed = false;
    public static bool colorBlue = false;
    public static bool colorRed = false;
    float rot;
    float size;


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

    private void Start()
    {
        int rand = Random.Range(0, 10);
        if (rand <= 2)
        {
            cont = 1;
        }
    }

    private void Awake()
    {
        switch (CarsManager.randPos)
        {
            case 0:
                mov = 1;
                //z-
                break;
            case 1:
                mov = 2;
                //z+
                break;
            case 2:
                mov = 3;
                //x-
                break;
            case 3:
                mov = 4;
                //x+
                break;
        }
    }

    private void Update()
    {
        if (Pause.Pausa)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else {
            if (cont % 2 != 0 &&!normalSpeed)
        {

            colorRed = true;
            colorBlue = false;
            switch (mov)
            {
                case 1:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.18f);
                        //z-
                        break;
                case 2:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 0.18f);
                        //z+
                        break;
                case 3:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.18f, gameObject.transform.position.y, gameObject.transform.position.z);
                        //x-
                        break;
                case 4:
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.18f, gameObject.transform.position.y, gameObject.transform.position.z);
                        //x+
                        break;
            }

        }
        else if ( cont % 2 == 0 && cont != 0 &&!normalSpeed)
        {
            colorRed = false;
            colorBlue = true;
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
            colorRed = false;
            colorBlue = true;
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
    
    }
    



