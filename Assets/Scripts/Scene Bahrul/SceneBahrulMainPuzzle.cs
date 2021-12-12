using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public enum lastPressed
{
    north_pressed,
    east_pressed,
    west_pressed,
    south_pressed,
    none
}
public class SceneBahrulMainPuzzle : MonoBehaviour
{
    public GameObject buttonNorth;
    public GameObject buttonEast;
    public GameObject buttonWest;
    public GameObject buttonSouth;
    public GameObject portal;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public Sprite switchOffSprite;
    public lastPressed buttonPressCondition = lastPressed.none;


    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(buttonPressCondition);
        if (buttonNorth.GetComponent<Button>().currentCondition == buttonCondition.pressed)
        {
            buttonPressCondition = lastPressed.north_pressed;
            Debug.Log(buttonPressCondition);
            if (buttonEast.GetComponent<Button>().currentCondition == buttonCondition.pressed)
            {
                buttonPressCondition = lastPressed.east_pressed;
                Debug.Log(buttonPressCondition);
                if (buttonWest.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                {
                    buttonPressCondition = lastPressed.west_pressed;
                    Debug.Log(buttonPressCondition);
                    if (buttonSouth.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                    {
                        Debug.Log("Congratulation");
                        portal.SetActive(true);
                        dialogBox.SetActive(true);
                        dialogText.text = dialog;
                        if (Input.GetKeyDown(KeyCode.Space) && dialogBox.activeInHierarchy)
                        {
                            dialogBox.SetActive(false);
                            buttonNorth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            buttonEast.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            buttonWest.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            buttonSouth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            buttonNorth.GetComponent<Button>().currentCondition = buttonCondition.not;
                            buttonEast.GetComponent<Button>().currentCondition = buttonCondition.not;
                            buttonWest.GetComponent<Button>().currentCondition = buttonCondition.not;
                            buttonSouth.GetComponent<Button>().currentCondition = buttonCondition.not;
                        }
                    }
                }
                else if (buttonSouth.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                {
                    buttonPressCondition = lastPressed.none;
                    buttonNorth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonEast.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonWest.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonSouth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    buttonNorth.GetComponent<Button>().currentCondition = buttonCondition.not;
                    buttonEast.GetComponent<Button>().currentCondition = buttonCondition.not;
                    buttonWest.GetComponent<Button>().currentCondition = buttonCondition.not;
                    buttonSouth.GetComponent<Button>().currentCondition = buttonCondition.not;
                }
            }
            else if (buttonWest.GetComponent<Button>().currentCondition == buttonCondition.pressed || buttonSouth.GetComponent<Button>().currentCondition == buttonCondition.pressed)
            {
                buttonPressCondition = lastPressed.none;
                buttonNorth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonEast.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonWest.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonSouth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                buttonNorth.GetComponent<Button>().currentCondition = buttonCondition.not;
                buttonEast.GetComponent<Button>().currentCondition = buttonCondition.not;
                buttonWest.GetComponent<Button>().currentCondition = buttonCondition.not;
                buttonSouth.GetComponent<Button>().currentCondition = buttonCondition.not;
            }
        }
        else if (buttonNorth.GetComponent<Button>().currentCondition != buttonCondition.pressed || buttonEast.GetComponent<Button>().currentCondition == buttonCondition.pressed || buttonWest.GetComponent<Button>().currentCondition == buttonCondition.pressed || buttonSouth.GetComponent<Button>().currentCondition == buttonCondition.pressed)
        {
            buttonPressCondition = lastPressed.none;
            buttonNorth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonEast.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonWest.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonSouth.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            buttonNorth.GetComponent<Button>().currentCondition = buttonCondition.not;
            buttonEast.GetComponent<Button>().currentCondition = buttonCondition.not;
            buttonWest.GetComponent<Button>().currentCondition = buttonCondition.not;
            buttonSouth.GetComponent<Button>().currentCondition = buttonCondition.not;
        }

    }
}
