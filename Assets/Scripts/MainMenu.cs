using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int sceneToContinue;
    public FloatValue currentPlayerHearts;
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void ExitGame(){
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void ContinueGame(){
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        currentPlayerHearts.RuntimeValue = PlayerPrefs.GetFloat("HealthRemaining");
        if(sceneToContinue != 0){
            SceneManager.LoadScene(sceneToContinue);
        }else return;
    }
}
