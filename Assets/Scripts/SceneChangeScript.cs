using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeScript : MonoBehaviour
{
    public void ToLevel1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void ToLevel2()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }



}
