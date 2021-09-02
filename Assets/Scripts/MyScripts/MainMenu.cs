using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayTheory()
    {
        SceneManager.LoadScene(1);
    }
    public void PlaySimulator()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayTest()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
