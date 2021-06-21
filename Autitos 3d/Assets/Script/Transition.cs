using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{

    public Animator trans;
    // Update is called once per frame
    void Update()
    {
        if (Menu.play)
        {
            loadNextLevel();
        }   
    }

    void loadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator LoadLevel(int levelIndex)
    {
        trans.SetTrigger("Start");
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(levelIndex);
        Menu.play = false;
        Menu.playAnima = false;

    }
}
