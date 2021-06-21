using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endGame;
    bool endgame = false;
    private void OnEnable()
    {
        endgame = false;
        endGame.SetActive(false);
    }


    private void Update()
    {
        if (saves.Lost)
        {
            endGame.SetActive(true);
            endgame = true;
            saves.Lost = false;
        }

    }

   

   

}
