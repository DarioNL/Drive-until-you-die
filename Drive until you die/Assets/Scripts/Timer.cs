using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //The starting time.
    private float timeValue = 0;

    //Determines whether the timer should run.
    public bool timerIsRunning = false;

    //The 3d text is stored in this.
    private TextMesh timeText;

    //// Start is called before the first frame update
    void Start()
    {
        // Starts the timer at the start of the game.
        timerIsRunning = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detects if the timer is on.
        if (timerIsRunning)
        {
            //If so, it calls the function.
            DisplayTime();
        }
    }

    //Measures the playing time and it causes the time displayed in the game to be refreshed.
    void DisplayTime() 
    {
        //Saves the text of the 3d text object in timeText
        TextMesh timeText = gameObject.GetComponent<TextMesh>();
        
        //Adds the time to the timer
        timeValue += Time.deltaTime;

        //Counts the minutes by dividing the time by 60.
        float minutes = Mathf.FloorToInt(timeValue / 60);

        //Counts the second by calculating the value remaining if you divide the time by 60.
        float seconds = Mathf.FloorToInt(timeValue % 60);

        //Adds the time in the correct format to the screen.
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
