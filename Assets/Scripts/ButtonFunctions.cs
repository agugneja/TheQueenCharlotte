using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{

    public void StartTimer() {
        // timer starts upon entering room
        GameMaster.Instance.timeLeft = 1800;
        GameMaster.Instance.timerIsRunning = true;
        GameMaster.Instance.ResetPuzzles();
    }

    public void KeyPickup() {
        PlayerPrefs.SetInt("HasDrawerKey", 1);
        GameMaster.Instance.hintCount = 13;
    }

    public void StopTimer() {
        if(PlayerPrefs.GetInt("HasDrawerKey") > 0) {
            GameMaster.Instance.timerIsRunning = false;
        }
    }

    public void SinkOn() {
        PlayerPrefs.SetInt("SinkOn", 1);
        GameMaster.Instance.hintCount = 8;
    }

}
