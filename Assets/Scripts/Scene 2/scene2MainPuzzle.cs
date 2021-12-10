using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum scene2button{
    none,
    button1pressed,
    button2pressed,
    button3pressed,
    button4pressed,
    button5pressed,
    button6pressed,
    button7pressed,
    button8pressed,
    button9pressed,
}
public class scene2MainPuzzle : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    private scene2button currentState = scene2button.none;
    public GameObject door;
    private void FixedUpdate()
    {
        Debug.Log(currentState);
        if(button3.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.none){
            currentState = scene2button.button3pressed;
        }
        if(button1.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button3pressed){
            currentState = scene2button.button1pressed;
        }
        if(button4.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button1pressed){
            currentState = scene2button.button4pressed;
        }
        if(button5.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button4pressed){
            currentState = scene2button.button5pressed;
        }
        if(button9.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button5pressed){
            currentState = scene2button.button9pressed;
        }
        if(button2.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button9pressed){
            currentState = scene2button.button2pressed;
        }
        if(button6.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button2pressed){
            currentState = scene2button.button6pressed;
        }
        if(button8.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button6pressed){
            currentState = scene2button.button8pressed;
        }
        if(button7.GetComponent<Button>().currentCondition == buttonCondition.pressed && currentState == scene2button.button8pressed){
            currentState = scene2button.button7pressed;
        }
        if(currentState == scene2button.button7pressed){
            Debug.Log("Congratulations");
            door.SetActive(false);
        }
    }

}
