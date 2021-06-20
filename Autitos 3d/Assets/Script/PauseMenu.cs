using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Animator anim;
    public GameObject pauseButton;
    public GameObject contador;
    bool finish = false;
    private void OnEnable()
    {
        finish = false;
    }
    private void Update()
    {
        if (!isPlaying() && !finish)
        {
            pauseButton.SetActive(false);
            Time.timeScale = 0;
            
        }
    }

   public void Resume()
    {
        if (Time.timeScale == 0) { 
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        contador.SetActive(true);
        Animator animObject= gameObject.GetComponent<Animator>();
        animObject.Play("DisapearMenu");
        finish = true;
        }
    }
    public void exitGame()
    {
        Application.Quit();
    }
    bool isPlaying()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("DisapearButton") &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }


}
