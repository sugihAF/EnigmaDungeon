using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
        SceneManager.sceneLoaded += LoadState;
    }

    //Resource
    public List<Sprite> playerSprite;

    public PlayerMovement player;
    public FloatingTextManager floatingTextManager;

    //logic
    public int money;

    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    public void SaveState(Scene s, LoadSceneMode mode)
    {
        Debug.Log("Save State");
    }
    public void LoadState(Scene s, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= LoadState;
        Debug.Log("Load State");
    }
}
