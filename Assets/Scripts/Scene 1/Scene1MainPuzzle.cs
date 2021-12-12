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
    public Sprite switchOffSprite;
    public pressCondition buttonPressCondition = pressCondition.none;
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
       Debug.Log(buttonPressCondition);
        if (buttonRed.GetComponent<Button>().currentCondition == buttonCondition.pressed)
        {
            buttonPressCondition = pressCondition.red_pressed;
            Debug.Log(buttonPressCondition);
            if (buttonBlue.GetComponent<Button>().currentCondition == buttonCondition.pressed)
            {
                buttonPressCondition = pressCondition.blue_pressed;
                Debug.Log(buttonPressCondition);
                if (buttonGreen.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                {
                    buttonPressCondition = pressCondition.green_pressed;
                    Debug.Log(buttonPressCondition);
                    if (buttonYellow.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                    {
                        Debug.Log("Congratulation");
                        portal.SetActive(true);
                    }
                }
                else if (buttonYellow.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                {
                    buttonPressCondition = pressCondition.none;
                    buttonRed.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonBlue.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonGreen.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonYellow.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonRed.GetComponent<Button>().currentCondition = buttonCondition.not;
                    buttonBlue.GetComponent<Button>().currentCondition = buttonCondition.not;
                    buttonGreen.GetComponent<Button>().currentCondition = buttonCondition.not;
                    buttonYellow.GetComponent<Button>().currentCondition = buttonCondition.not;
                }
            }
            else if (buttonGreen.GetComponent<Button>().currentCondition == buttonCondition.pressed || buttonYellow.GetComponent<Button>().currentCondition == buttonCondition.pressed)
            {
                buttonPressCondition = pressCondition.none;
                buttonRed.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonBlue.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonGreen.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonYellow.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonRed.GetComponent<Button>().currentCondition = buttonCondition.not;
                buttonBlue.GetComponent<Button>().currentCondition = buttonCondition.not;
                buttonGreen.GetComponent<Button>().currentCondition = buttonCondition.not;
                buttonYellow.GetComponent<Button>().currentCondition = buttonCondition.not;
            }
        }
        else if (buttonRed.GetComponent<Button>().currentCondition != buttonCondition.pressed || buttonBlue.GetComponent<Button>().currentCondition == buttonCondition.pressed || buttonGreen.GetComponent<Button>().currentCondition == buttonCondition.pressed || buttonYellow.GetComponent<Button>().currentCondition == buttonCondition.pressed)
        {
            buttonPressCondition = pressCondition.none;
            buttonRed.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonBlue.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonGreen.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonYellow.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonRed.GetComponent<Button>().currentCondition = buttonCondition.not;
            buttonBlue.GetComponent<Button>().currentCondition = buttonCondition.not;
            buttonGreen.GetComponent<Button>().currentCondition = buttonCondition.not;
            buttonYellow.GetComponent<Button>().currentCondition = buttonCondition.not;
        }

    }
}
