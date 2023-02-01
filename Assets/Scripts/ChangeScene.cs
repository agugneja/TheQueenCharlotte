using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int scene;
    public List<GameObject> canvas;

    //changes scene based on scene picked in unity, generic
    public void changeScene() {
        SceneManager.LoadScene(scene);
    }

    public void changeSceneSafe() {
        if(PlayerPrefs.GetInt("SafePuzzle") > 0) {
            SceneManager.LoadScene("closetWithNote");
        }
        else {
            SceneManager.LoadScene("safeCloseUp");
        }
    }

    public void changeSceneDrawer() {
        if(PlayerPrefs.GetInt("OuijaBoardComplete") > 0) {
            if(PlayerPrefs.GetInt("HasDrawerKey") < 1) {

                SceneManager.LoadScene("drawer");

            }
            else {
                SceneManager.LoadScene("drawerEmpty");
            }
        }
    }

    public void changeSceneDoor() {
        if(PlayerPrefs.GetInt("HasDrawerKey") > 0) {
            SceneManager.LoadScene("gameEndWin");
        }
    }

    public void disable() {
        foreach (GameObject obj in canvas) { 
            obj.SetActive(!obj.activeSelf);
        }
        //canvas.SetActive(!canvas.activeSelf);
    }

    //will quit game on click
    public void QuitGame() {
        //to ensure method is working
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
