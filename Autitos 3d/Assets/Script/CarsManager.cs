using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsManager : MonoBehaviour
{
    float delay;
    public GameObject car;
   public static int randPos;
    int[] randoms = new int[4];
    int numeroAnterior=-1;

    private void Awake()
    {
        for(int i=0; i < 4; i++)
        {
            randoms[i] = i;
        }


        Debug.Log(randPos);

    }
    private void Update()
    {

        if (delay < 0)
        {

            insCar();
            return;
        }
        else
        {

            delay -= Time.deltaTime;


        }
    }

    void insCar()
    {
        car.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane + 20));
        randPos = Random.Range(0, 4);
        if (randoms[randPos]!=-1)
        {
            Vector3 randPosition = new Vector3();
            if (numeroAnterior == -1)
            {
                switch (randoms[randPos])
                {
                    case 0:
                        randPosition = new Vector3(car.transform.position.x - 1.5f, car.transform.position.y + 1, car.transform.position.z + 14);
                        Instantiate(car, randPosition, Quaternion.Euler(0, 180, 0));
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //z-
                        break;
                    case 1:
                        randPosition = new Vector3(car.transform.position.x + 1.5f, car.transform.position.y + 1, car.transform.position.z - 14);
                        Instantiate(car, randPosition, Quaternion.identity);
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //z+
                        break;
                    case 2:
                        randPosition = new Vector3(car.transform.position.x + 14, car.transform.position.y + 1, car.transform.position.z + 1.5f);
                        Instantiate(car, randPosition, Quaternion.Euler(0, -90, 0));
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //x-
                        break;
                    case 3:
                        randPosition = new Vector3(car.transform.position.x - 14, car.transform.position.y + 1, car.transform.position.z - 1.5f);
                        Instantiate(car, randPosition, Quaternion.Euler(0, 90, 0));
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //x+
                        break;
                }
            }
            else
            {
                switch (randoms[randPos])
                {
                    case 0:
                        randPosition = new Vector3(car.transform.position.x - 1.5f, car.transform.position.y + 1, car.transform.position.z + 14);
                        Instantiate(car, randPosition, Quaternion.Euler(0, 180, 0));
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //z-
                        break;
                    case 1:
                        randPosition = new Vector3(car.transform.position.x + 1.5f, car.transform.position.y + 1, car.transform.position.z - 14);
                        Instantiate(car, randPosition, Quaternion.identity);
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //z+
                        break;
                    case 2:
                        randPosition = new Vector3(car.transform.position.x + 14, car.transform.position.y + 1, car.transform.position.z + 1.5f);
                        Instantiate(car, randPosition, Quaternion.Euler(0, -90, 0));
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //x-
                        break;
                    case 3:
                        randPosition = new Vector3(car.transform.position.x - 14, car.transform.position.y + 1, car.transform.position.z - 1.5f);
                        Instantiate(car, randPosition, Quaternion.Euler(0, 90, 0));
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //x+
                        break;
                }
            }

            delay = 1f;

        }
        else
        {
            randPos = Random.Range(0, 4);
        }
    }

    }
