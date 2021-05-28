using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //Called when someone clicks the start button
    public void StartGame()
    {
        //Changes the scene to the game scene
        SceneManager.LoadScene("Game");
    }

    //Called when someone clicks the quit button
    public void QuitGame()
    {
        //Exit the game(does not work in the editor).
        Application.Quit();
    }

}
