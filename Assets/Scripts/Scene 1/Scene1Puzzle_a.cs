using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Puzzle_a : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject switchButton;

    private void Update()
    {
        if(!enemies[0].activeSelf && !enemies[1].activeSelf && !enemies[2].activeSelf){
            switchButton.SetActive(true);
        }
    }
}
