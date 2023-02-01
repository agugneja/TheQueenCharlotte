using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Planchette : MonoBehaviour
{
    public Button[] button;
    public Button enter;
    public Button clear;
    public Text answerText;
    private string answer = "";

    Dictionary<int, char> alphabet = new Dictionary <int, char>();


    // Start is called before the first frame update
    void Start() {

        int progressCheck = PlayerPrefs.GetInt("OuijaBoardComplete");
        if(progressCheck > 0) {
            answerText.text = "EMILY";
            answerText.GetComponent<Text>().color = Color.green;
            enter.gameObject.SetActive(false);
            clear.gameObject.SetActive(false);
            for(int i = 0; i < button.Length; i++) {
                button[i].gameObject.SetActive(false);
            }
            return;
        }

        //Ensures text is blank when puzzle starts
        answerText.text = "";

        //Adds all the buttons to an array and listens for their click
        for(int i = 0; i < button.Length; i++) {
            int tmp = i;
            button[i].onClick.AddListener(() => OnButtonClick(tmp+1));
        }

        //Defines all values and keys to convert button clicks into letters
        alphabet.Add(1, 'A');
        alphabet.Add(2, 'B');
        alphabet.Add(3, 'C');        
        alphabet.Add(4, 'D');
        alphabet.Add(5, 'E');
        alphabet.Add(6, 'F');
        alphabet.Add(7, 'G');
        alphabet.Add(8, 'H');
        alphabet.Add(9, 'I');
        alphabet.Add(10, 'J');
        alphabet.Add(11, 'K');
        alphabet.Add(12, 'L');
        alphabet.Add(13, 'M');
        alphabet.Add(14, 'N');
        alphabet.Add(15, 'O');
        alphabet.Add(16, 'P');
        alphabet.Add(17, 'Q');
        alphabet.Add(18, 'R');
        alphabet.Add(19, 'S');
        alphabet.Add(20, 'T');
        alphabet.Add(21, 'U');
        alphabet.Add(22, 'V');
        alphabet.Add(23, 'W');
        alphabet.Add(24, 'X');
        alphabet.Add(25, 'Y');
        alphabet.Add(26, 'Z');

    }

    //Converts a button click to the corresponding character, and concatenates the selected letter into an answer string
    void OnButtonClick(int buttonNumber) {
        answer = answer + alphabet[buttonNumber];
        answerText.text = answer;
    }

    //Checks if the entered text string is the correct answer to the puzzle
    public void enterText() {
        if (answer.Equals("EMILY")){
            answerText.GetComponent<Text>().color = Color.green;
            PlayerPrefs.SetInt("OuijaBoardComplete", 1);
            GameMaster.Instance.hintCount = 11;
            SceneManager.LoadScene("sittingRoom");
        }

        //If the answer is not correct the text turns red to alert the player
        else {
            answerText.GetComponent<Text>().color = Color.red;
        }
    }

    //Clears any stored answers so the player can attempt a new solution
    public void clearText() {
        answer = "";
        answerText.text = "";
        answerText.GetComponent<Text>().color = Color.black;
    }

}
