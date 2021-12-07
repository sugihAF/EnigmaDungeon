using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum pressCondition{
    red_pressed,
    blue_pressed,
    green_pressed,
    yellow_pressed,
    none
}
public class Scene1MainPuzzle : MonoBehaviour
{
    
    public GameObject buttonGreen;
    public GameObject buttonBlue;
    public GameObject buttonRed;
    public GameObject buttonYellow;
    public GameObject portal;
    public pressCondition buttonPressCondition = pressCondition.none;
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(buttonPressCondition);
        if(buttonRed.GetComponent<Button>().currentCondition == buttonCondition.pressed && buttonPressCondition == pressCondition.none){
            buttonPressCondition = pressCondition.red_pressed;
                    Debug.Log(buttonPressCondition);}
        if(buttonBlue.GetComponent<Button>().currentCondition == buttonCondition.pressed && buttonPressCondition == pressCondition.red_pressed){
            buttonPressCondition = pressCondition.blue_pressed;
                    Debug.Log(buttonPressCondition);}
        if(buttonGreen.GetComponent<Button>().currentCondition == buttonCondition.pressed && buttonPressCondition == pressCondition.blue_pressed){
            buttonPressCondition = pressCondition.green_pressed;
                    Debug.Log(buttonPressCondition);}
        if(buttonYellow.GetComponent<Button>().currentCondition == buttonCondition.pressed && buttonPressCondition == pressCondition.green_pressed){
            buttonPressCondition = pressCondition.yellow_pressed;
                    Debug.Log(buttonPressCondition);}
        if(buttonPressCondition == pressCondition.yellow_pressed){
            Debug.Log("Congratulation");
            portal.SetActive(true);
        }
    }
}
