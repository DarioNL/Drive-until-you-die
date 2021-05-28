using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    //Which text object to modify.
    public TextMeshProUGUI pTime;

    // Start is called before the first frame update.
    public void Start()
    {
        //Inserts the value for the last time.
        pTime.text = Timer.time;
    }

    //Called when someone clicks the restart button.
    public void RestartGame()
    {
        //Changes the scene to the game scene.
        SceneManager.LoadScene("Game");
    }

    //Called when someone clicks the menu button.
    public void GoToMenu()
    {
        //Changes the scene to the menu scene.
        SceneManager.LoadScene("Start");
    }
}
