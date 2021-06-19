using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsManager : MonoBehaviour
{
    float delay;
    public GameObject car;
   public static int randPos;
  public static  List<GameObject> leftDown= new List<GameObject>();
    public static List<GameObject> leftUp = new List<GameObject>();
    public static List<GameObject> RightDown = new List<GameObject>();
    public static List<GameObject> RightUp = new List<GameObject>();


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
        car.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane +20));
        randPos = Random.Range(1, 5);
        Vector3 randPosition = new Vector3();
        switch (randPos)
        {
            case 1:
                randPosition = new Vector3(car.transform.position.x - 1.5f, car.transform.position.y+1, car.transform.position.z + 14);
                Instantiate(car, randPosition, Quaternion.Euler(0, 180, 0));
                RightUp.Add(car);

                //z-
                break;
            case 2:
                randPosition = new Vector3(car.transform.position.x + 1.5f, car.transform.position.y+1, car.transform.position.z - 14);
                Instantiate(car, randPosition, Quaternion.identity);
                leftUp.Add(car);

                //z+
                break;
            case 3:
                randPosition = new Vector3(car.transform.position.x + 14, car.transform.position.y+1, car.transform.position.z + 1.5f);
                Instantiate(car, randPosition, Quaternion.Euler(0,-90,0));
                RightDown.Add(car);

                //x-
                break;
            case 4:
                randPosition = new Vector3(car.transform.position.x - 14, car.transform.position.y+1, car.transform.position.z - 1.5f);
                Instantiate(car, randPosition, Quaternion.Euler(0, 90, 0));
                leftDown.Add(car);

                //x+
                break;
        }


        delay = 1f;
    }
}
