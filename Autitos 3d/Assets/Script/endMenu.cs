using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endMenu : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0;

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
