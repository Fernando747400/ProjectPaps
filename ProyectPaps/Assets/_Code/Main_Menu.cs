using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public string sceneToLoad;
    public string creditsScene;
   public void startGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void credits()
    {
        SceneManager.LoadScene(creditsScene);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
