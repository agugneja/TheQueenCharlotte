using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PaintingToSafe : MonoBehaviour
{
    public Button[] button;
    private bool button1 = false;
    private bool button2 = false;
    private bool button3 = false;
    private bool button4 = false;

    // Start is called before the first frame update
    void Start() {
        for(int i = 0; i < button.Length; i++) {
            int tmp = i;
            button[i].onClick.AddListener(() => OnButtonClick(tmp));
        }
    }

    void OnButtonClick(int buttonNumber) {

        //Checking what button is pressed, used for debugging only
        //Debug.Log("You pressed button " + buttonNumber);

        //FinalCheck, changes scene if all buttons before were hit in the correct order
        if(buttonNumber == 11 && button1 && button2 && button3 && button4) {
            PlayerPrefs.SetInt("SafePuzzle", 1);
            GameMaster.Instance.hintCount = 4;
            SceneManager.LoadScene("closetWithNote");

        }
        //Checks the first number in the seqence
        else if(buttonNumber == 5) {
            button[5].GetComponent<Image>().color = Color.green;
            button1 = true;
        }
        //Checks the second number in the seqence
        else if(button1 == true && buttonNumber == 0) {
            button[5].GetComponent<Image>().color = Color.green;
            button[0].GetComponent<Image>().color = Color.green;
            button2 = true;
        }
        //Checks the third number in the seqence
        else if(button2 == true && buttonNumber == 3) {
            button[5].GetComponent<Image>().color = Color.green;
            button[0].GetComponent<Image>().color = Color.green;
            button[3].GetComponent<Image>().color = Color.green;
            button3 = true;
        }
        //Checks the Fourth number in the seqence
        else if(button3 == true && buttonNumber == 7) {
            button[5].GetComponent<Image>().color = Color.green;
            button[0].GetComponent<Image>().color = Color.green;
            button[3].GetComponent<Image>().color = Color.green;
            button[7].GetComponent<Image>().color = Color.green;
            button4 = true;
        }
        //Handles any wrong input during any stage of the puzzle. 
        else {
            button1 = button2 = button3 = button4 = false;
            for(int i = 0; i < button.Length; i++) {
                button[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
}
