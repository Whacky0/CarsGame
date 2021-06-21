using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI Tiempo;
    public static float seconds;
    public static float delay=2f;
    public GameObject cont;
    public GameObject menuPause;


    // Start is called before the first frame update
    void Start()
    {
        Tiempo.text = 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (cont.activeInHierarchy == false && menuPause.activeInHierarchy==false ) { 
        seconds += Time.deltaTime;
        Tiempo.text =Mathf.RoundToInt(seconds).ToString();
        if (Tiempo.text == 10.ToString() )
        {
            delay= 1.9f;
        }
        if (Tiempo.text == 30.ToString())
        {
            delay = 1.8f;
        }
        if (Tiempo.text == 50.ToString())
        {
            delay = 1.7f;
        }
        if (Tiempo.text == 70.ToString())
        {
            delay = 1.6f;
        }
        if (Tiempo.text == 90.ToString())
        {
            delay = 1.5f;
        }
        if (Tiempo.text == 120.ToString())
        {
            delay = 1.4f;
        }
        if (Tiempo.text == 150.ToString())
        {
            delay = 1.3f;
        }



        }
        


    }



}
