using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsManager : MonoBehaviour
{
    public static float delay;
    public GameObject car;
   public static int randPos;
    int[] randoms = new int[4];
    int numeroAnterior=-1;
    public GameObject cont;
    public GameObject menuPause;
    public GameObject x;
    public GameObject xM;
    public GameObject z;
    public GameObject zM;

    private void Awake()
    {
        for(int i=0; i < 4; i++)
        {
            randoms[i] = i;
        }



    }

    
    private void Update()
    {

        if (delay < 0 && cont.activeInHierarchy==false &&menuPause.activeInHierarchy==false)
        {
            insCar();
            return;
        }
        else if(delay>=0&& cont.activeInHierarchy == false &&menuPause.activeInHierarchy == false)
        {

            delay -= Time.deltaTime;


        }
    }

    void insCar()
    {
       // car.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2.5f, Camera.main.nearClipPlane + 20));
        randPos = Random.Range(0, 4);
        if (randoms[randPos]!=-1)
        {
            Vector3 randPosition = new Vector3();
            if (numeroAnterior == -1)
            {
                switch (randoms[randPos])
                {
                    case 0:
                        Debug.Log(randPos);
                        randPosition = xM.transform.position;
                        Instantiate(car, randPosition, Quaternion.Euler(0, 180, 0));
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //z-
                        break;
                    case 1:
                        Debug.Log(randPos);
                        randPosition = x.transform.position;
                        Instantiate(car, randPosition, Quaternion.identity);
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //z+
                        break;
                    case 2:
                        Debug.Log(randPos);
                        randPosition = z.transform.position;
                        Instantiate(car, randPosition, Quaternion.Euler(0, -90, 0));
                        randoms[randPos] = -1;
                        numeroAnterior = randPos;
                        //x-
                        break;
                    case 3:
                        Debug.Log(randPos);
                        randPosition = zM.transform.position;
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
                        Debug.Log(randPos);
                        randPosition = xM.transform.position;
                        Instantiate(car, randPosition, Quaternion.Euler(0, 180, 0));
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //z-
                        break;
                    case 1:
                        Debug.Log(randPos);
                        randPosition = x.transform.position;
                        Instantiate(car, randPosition, Quaternion.identity);
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //z+
                        break;
                    case 2:
                        Debug.Log(randPos);
                        randPosition = z.transform.position;
                        Instantiate(car, randPosition, Quaternion.Euler(0, -90, 0));
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //x-
                        break;
                    case 3:
                        Debug.Log(randPos);
                        randPosition = zM.transform.position;
                        Instantiate(car, randPosition, Quaternion.Euler(0, 90, 0));
                        randoms[numeroAnterior] = numeroAnterior;
                        numeroAnterior = -1;
                        //x+
                        break;
                }
            }

            delay = TimeManager.delay;

        }
        else
        {
            randPos = Random.Range(0, 4);
            Debug.Log(randPos);
        }
    }

    }
