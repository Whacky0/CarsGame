    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool Pausa;
    public GameObject pauseMenu;
    public Animator anim;
    bool play = false;

    private void OnEnable()
    {
        anim.Play("ApearButton");

    }


    public void PauseGame()
    {
        Pausa = true;
        pauseMenu.SetActive(true);
        anim.Play("DisapearButton");
 
        

    }

   
}
