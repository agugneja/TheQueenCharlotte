using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintGiver : MonoBehaviour
{
    public Text hintText;

    void FixedUpdate() {
        Debug.Log("FixedUpdate starts, GameMaster.Instance.Hintcount = " + GameMaster.Instance.hintCount);
        if((PlayerPrefs.GetInt("SafePuzzle") < 1)) {
            if(GameMaster.Instance.timeLeft < 1710 && GameMaster.Instance.hintCount == 0) {
                hintText.text = "WHAT A STRANGE ROOM. BETTER GET EXPLORING.";
                GameMaster.Instance.hintCount = 1;
            }
            else if(GameMaster.Instance.timeLeft < 1620 && GameMaster.Instance.hintCount == 1) {
                hintText.text = "HMMM, THAT PAINTING ABOVE THE BED LOOKS ODD...";
                GameMaster.Instance.hintCount = 2;
            }
            else if(GameMaster.Instance.timeLeft < 1530 && GameMaster.Instance.hintCount == 2) {
                hintText.text = "MAYBE TRY THAT ENTERING THAT CODE SOMEWHERE.";
                GameMaster.Instance.hintCount = 3; 
            }
            else if(GameMaster.Instance.timeLeft < 1440 && GameMaster.Instance.hintCount == 3) {
                hintText.text = "HAVE YOU TRIED PRESSING POUND???";
                GameMaster.Instance.hintCount = 4;
            }
        }
        else if(PlayerPrefs.GetInt("SinkOn") < 1) {
            if(GameMaster.Instance.timeLeft < 1350 && GameMaster.Instance.hintCount == 4) {
                Debug.Log("HINT COUNT" + GameMaster.Instance.hintCount);
                hintText.text = "WHAT CLUES DID THE PREVIOUS GUEST LEAVE BEHIND?";
                GameMaster.Instance.hintCount = 5;
            }
            else if(GameMaster.Instance.timeLeft < 1260 && GameMaster.Instance.hintCount == 5) {
                hintText.text = "TRY INVESTIGATING SOME OF THE WEIRD THINGS MENTIONED IN THAT NOTE.";
                GameMaster.Instance.hintCount = 6;
            }
            else if(GameMaster.Instance.timeLeft < 1170 && GameMaster.Instance.hintCount == 6) {
                hintText.text = "WHAT'S THE DEAL WITH THE BOILING WATER THE NOTE MENTIONED?";
                GameMaster.Instance.hintCount = 7;
            }
            else if(GameMaster.Instance.timeLeft < 1080 && GameMaster.Instance.hintCount == 7){
                hintText.text = "TURN ON THE SINK.";
                GameMaster.Instance.hintCount = 8;
            }
        }
        else if(PlayerPrefs.GetInt("OuijaBoardComplete") < 1) {
            if(GameMaster.Instance.timeLeft < 990 && GameMaster.Instance.hintCount == 8) {
                hintText.text = "COULD THIS BE THE SPIRIT HAUNTING THE ROOM?";
                GameMaster.Instance.hintCount = 9;
            }
            else if(GameMaster.Instance.timeLeft < 900 && GameMaster.Instance.hintCount == 9) {
                hintText.text = "TRY COMMUNICATING WITH THE SPIRIT.";
                GameMaster.Instance.hintCount = 10;
            }
            else if(GameMaster.Instance.timeLeft < 810 && GameMaster.Instance.hintCount == 10){
                hintText.text = "THAT OUIJA BOARD IS THE PERFECT TOOL FOR THE JOB.";
                GameMaster.Instance.hintCount = 11;
            }
        }
        else if(PlayerPrefs.GetInt("HasDrawerKey") < 1) {
            if(GameMaster.Instance.timeLeft < 720 && GameMaster.Instance.hintCount == 11) {
                hintText.text = "OH LOOK, THAT DRAWER OPENED. WHAT COULD BE INSIDE?";
                GameMaster.Instance.hintCount = 12;
            }
            else if(GameMaster.Instance.timeLeft < 630 && GameMaster.Instance.hintCount == 12){
                hintText.text = "GET THE KEY OUT OF THE DRAWER.";
                GameMaster.Instance.hintCount = 13;
            }
        }
        else if(PlayerPrefs.GetInt("HasDrawerKey") > 0) {
            if(GameMaster.Instance.timeLeft < 540 && GameMaster.Instance.hintCount == 13) {
                hintText.text = "TIME TO LEAVE";
                GameMaster.Instance.hintCount = 14;
            }
            else if(GameMaster.Instance.timeLeft < 450 && GameMaster.Instance.hintCount == 14) {
                hintText.text = "GO AHEAD AND GET OUT OF HERE";
                GameMaster.Instance.hintCount = 15;
            }
            else if(GameMaster.Instance.timeLeft < 360 && GameMaster.Instance.hintCount == 15) {
                hintText.text = "ARE YOU SERIOUS?? THE DOOR IS RIGHT THERE.";
                GameMaster.Instance.hintCount = 16;
            }
            else if(GameMaster.Instance.timeLeft < 270 && GameMaster.Instance.hintCount == 16) {
                hintText.text = "WHAT ARE YOU WAITING FOR??? JUST TURN AROUND AND WALK OUT THE DOOR.";
                GameMaster.Instance.hintCount = 17;
            }
            else if(GameMaster.Instance.timeLeft < 30 && GameMaster.Instance.hintCount == 17){
                hintText.text = "...OKAY, YOU GOT IT. JUST LEAVE ALREADY.";
            }
        }
    
    }
}


