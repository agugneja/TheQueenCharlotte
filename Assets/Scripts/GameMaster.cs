using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster Instance;
    //if this script is attached to an object it will persist across scenes
    //tutorial from https://www.sitepoint.com/saving-data-between-scenes-in-unity/
    void Awake() {
        if(Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this) {
            Destroy(gameObject);
        }
    }

    public float timeLeft = 10;
    public bool timerIsRunning = false;
    public Text timerText;
    public int hintCount = 0;

    void Update() {
        if (timerIsRunning) {
            //if time left display time
            if (timeLeft > 0) {
                timeLeft -= Time.deltaTime;
                DisplayTime(timeLeft);
            }
            //else end game
            else {
                timerIsRunning = false;
                ResetPuzzles();
                SceneManager.LoadScene("gameEndLoss");
                Debug.Log("YOU LOST");
            }
        }
        Debug.Log("SAFE" + PlayerPrefs.GetInt("SafePuzzle"));
        Debug.Log("SINK" + PlayerPrefs.GetInt("SinkOn"));
        Debug.Log("Hint count is :" + hintCount);
    }
    //displays time left
    void DisplayTime(float time) {
        time += 1;
        float minutes = Mathf.FloorToInt(time / 60); 
        float seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    //Resets puzzles on game start
    public void ResetPuzzles() {
        //PlayerPrefs.SetInt(KeyName, Value);
        PlayerPrefs.SetInt("OuijaBoardComplete", 0);
        PlayerPrefs.SetInt("SafePuzzle", 0);
        PlayerPrefs.SetInt("HasDrawerKey", 0);
        PlayerPrefs.SetInt("SinkOn", 0);
    }

}
