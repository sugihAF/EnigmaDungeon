using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_1 : MonoBehaviour
{
    public GameObject pot;
    public GameObject chest;
    void Update()
    {
        if(pot.activeInHierarchy == false){
            chest.SetActive(true);
        }
    }
}
