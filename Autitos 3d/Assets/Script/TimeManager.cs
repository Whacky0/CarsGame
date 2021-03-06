using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI Tiempo;
    public static float seconds;
    public static float delay=1.6f;
    public GameObject cont;
    public GameObject menuPause;

    private void Awake()
    {
       delay = 1.6f;
    Tiempo.text = 0.ToString();
        Time.timeScale = 1;
        Debug.Log(delay);
    }



    // Update is called once per frame
    void Update()
    {
        if (cont.activeInHierarchy == false && menuPause.activeInHierarchy==false ) { 
        seconds += Time.deltaTime;
        Tiempo.text =Mathf.RoundToInt(seconds).ToString();
        if (Tiempo.text == 10.ToString() )
        {
            delay= 1.5f;
        }
        if (Tiempo.text == 30.ToString())
        {
            delay = 1.4f;
        }
        if (Tiempo.text == 50.ToString())
        {
            delay = 1.3f;
        }
        if (Tiempo.text == 70.ToString())
        {
            delay = 1.2f;
        }
        if (Tiempo.text == 90.ToString())
        {
            delay = 1.1f;
        }

        if (Tiempo.text == 150.ToString())
        {
            delay = 1.0f;
        }
            if (Tiempo.text == 200.ToString())
            {
                delay = 0.9f;
            }
            if (Tiempo.text == 250.ToString())
            {
                delay = 0.8f;
            }
            if (Tiempo.text == 350.ToString())
            {
                delay = 0.7f;
            }
            if (Tiempo.text == 500.ToString())
            {
                delay = 0.6f;
            }

        }
        


    }



}
