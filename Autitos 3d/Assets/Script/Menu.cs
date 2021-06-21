using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public static bool play = false;
    public Animator[] transWord = new Animator[4];
   public static bool playAnima = false;
    int cont = 0;
    public GameObject[] obs = new GameObject[4];

    public void Play()
    {
        play = true;
        playAnima = true;
    }

    private void Update()
    {
        if (!playAnima && !isPlaying() && cont == 1)
        {
            for (int i = 0; i < 4; i++)
            {

                obs[i].SetActive(false);
            }
        }
        else if (playAnima)
        {
            playAnim();
        }
       

    }

    void playAnim()
    {
        if (playAnima) {
            for (int i = 0; i < 4; i++)
            {
                transWord[i].Play("AnimationOver");
            }

            playAnima = false;
            cont = 1;
        }

    }
    public void Exit()
    {
        Application.Quit();
    }
    bool isPlaying()
    {
        if (transWord[0].GetCurrentAnimatorStateInfo(0).IsName("AnimationOver") &&
                transWord[0].GetCurrentAnimatorStateInfo(0).normalizedTime < 0.9f)
            return true;
        else
            return false;
    }
}
