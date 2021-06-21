using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class endMenu : MonoBehaviour
{
    string gameId = "101113";
    bool testMode = true;
    private void OnEnable()
    {
        Advertisement.Initialize(gameId, testMode);
        Time.timeScale = 0;
        Advertisement.Show();


    }
    public void Restart()
    {
        TimeManager.seconds = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
    public void exit()
    {
        Application.Quit();
    }
}
