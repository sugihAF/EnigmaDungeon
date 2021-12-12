using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseUI;
    public GameObject gameOverUI;
    public FloatValue playerHealth;
    private int currentSceneIndex;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
        if(playerHealth.RuntimeValue == 0){
            gameOverUI.SetActive(true);
        }
    }

    public void Resume(){
        FindObjectOfType<SoundManager>().PlaySound("unpause");
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        FindObjectOfType<SoundManager>().PlaySound("pause");
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMainMenu(){

        Time.timeScale = 1f;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene",currentSceneIndex);
        PlayerPrefs.SetFloat("HealthRemaining",playerHealth.RuntimeValue);
        SceneManager.LoadScene(0);
    }
    public void retry(){
        playerHealth.RuntimeValue = playerHealth.initialValue;
        gameOverUI.SetActive(false);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
    public void Finish(){
        playerHealth.RuntimeValue = playerHealth.initialValue;
        gameOverUI.SetActive(false);
        PlayerPrefs.SetInt("SavedScene",1);
        SceneManager.LoadScene(0);
    }
}
