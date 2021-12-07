using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Puzzle_a : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject switchButton;

    private void Update()
    {
        if(!enemies[0].active && !enemies[1].active && !enemies[2].active){
            switchButton.SetActive(true);
        }
    }
}
