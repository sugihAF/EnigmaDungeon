using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2SignPuzzle : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject additionalSign;

    private void Update()
    {
        if(!enemies[0].active && !enemies[1].active && !enemies[2].active && !enemies[3].active && !enemies[4].active && !enemies[5].active
         && !enemies[6].active && !enemies[7].active && !enemies[8].active && !enemies[9].active && !enemies[10].active && !enemies[11].active){
            additionalSign.SetActive(true);
        }
    }
}
