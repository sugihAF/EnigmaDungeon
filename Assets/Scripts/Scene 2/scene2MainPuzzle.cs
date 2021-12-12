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
    private scene2button buttonscene2button = scene2button.none;
    public GameObject door;
    public Sprite switchOffSprite;
    void FixedUpdate()
    {
       Debug.Log(buttonscene2button);
        if (button1.GetComponent<Button>().currentCondition == buttonCondition.pressed)
        {
            buttonscene2button = scene2button.button1pressed;
            Debug.Log(buttonscene2button);
            if (button2.GetComponent<Button>().currentCondition == buttonCondition.pressed)
            {
                buttonscene2button = scene2button.button2pressed;
                Debug.Log(buttonscene2button);
                if (button3.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                {
                    buttonscene2button = scene2button.button3pressed;
                    Debug.Log(buttonscene2button);
                    if (button4.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                    {
                        buttonscene2button = scene2button.button4pressed;
                        Debug.Log(buttonscene2button);
                        if (button5.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                        {
                            buttonscene2button = scene2button.button5pressed;
                            Debug.Log(buttonscene2button);
                            if (button6.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                            {
                                buttonscene2button = scene2button.button6pressed;
                                Debug.Log(buttonscene2button);
                                if (button7.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                                {
                                    buttonscene2button = scene2button.button7pressed;
                                    Debug.Log(buttonscene2button);
                                    if (button8.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                                    {
                                        buttonscene2button = scene2button.button8pressed;
                                        Debug.Log(buttonscene2button);
                                        if (button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                                        {
                                            Debug.Log("Congratulation");
                                            door.SetActive(false);
                                        }
                                    }
                                    else if (button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                                    {
                                        buttonscene2button = scene2button.none;
                                        button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                        button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                                        button9.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    }
                                }
                                else if (button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                                {
                                    buttonscene2button = scene2button.none;
                                    button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                    button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                                    button9.GetComponent<Button>().currentCondition = buttonCondition.not;
                                }
                            }
                            else if (button7.GetComponent<Button>().currentCondition == buttonCondition.pressed || button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                            {
                                buttonscene2button = scene2button.none;
                                button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                                button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                                button9.GetComponent<Button>().currentCondition = buttonCondition.not;
                            }
                        }
                        else if (button6.GetComponent<Button>().currentCondition == buttonCondition.pressed || button7.GetComponent<Button>().currentCondition == buttonCondition.pressed || button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                        {
                            buttonscene2button = scene2button.none;
                            button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                            button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                            button9.GetComponent<Button>().currentCondition = buttonCondition.not;
                        }
                    }
                    else if (button5.GetComponent<Button>().currentCondition == buttonCondition.pressed || button6.GetComponent<Button>().currentCondition == buttonCondition.pressed || button7.GetComponent<Button>().currentCondition == buttonCondition.pressed || button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                    {
                        buttonscene2button = scene2button.none;
                        button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                        button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                        button9.GetComponent<Button>().currentCondition = buttonCondition.not;
                    }
                }
                else if (button4.GetComponent<Button>().currentCondition == buttonCondition.pressed || button5.GetComponent<Button>().currentCondition == buttonCondition.pressed || button6.GetComponent<Button>().currentCondition == buttonCondition.pressed || button7.GetComponent<Button>().currentCondition == buttonCondition.pressed || button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
                {
                    buttonscene2button = scene2button.none;
                    button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                    button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                    button9.GetComponent<Button>().currentCondition = buttonCondition.not;
                }
            }
            else if (button3.GetComponent<Button>().currentCondition == buttonCondition.pressed || button4.GetComponent<Button>().currentCondition == buttonCondition.pressed || button5.GetComponent<Button>().currentCondition == buttonCondition.pressed || button6.GetComponent<Button>().currentCondition == buttonCondition.pressed || button7.GetComponent<Button>().currentCondition == buttonCondition.pressed || button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
            {
                buttonscene2button = scene2button.none;
                button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                button1.GetComponent<Button>().currentCondition = buttonCondition.not;
                button2.GetComponent<Button>().currentCondition = buttonCondition.not;
                button3.GetComponent<Button>().currentCondition = buttonCondition.not;
                button4.GetComponent<Button>().currentCondition = buttonCondition.not;
                button5.GetComponent<Button>().currentCondition = buttonCondition.not;
                button6.GetComponent<Button>().currentCondition = buttonCondition.not;
                button7.GetComponent<Button>().currentCondition = buttonCondition.not;
                button8.GetComponent<Button>().currentCondition = buttonCondition.not;
                button9.GetComponent<Button>().currentCondition = buttonCondition.not;
            }
        }
        else if (button1.GetComponent<Button>().currentCondition != buttonCondition.pressed || button2.GetComponent<Button>().currentCondition == buttonCondition.pressed || button3.GetComponent<Button>().currentCondition == buttonCondition.pressed || button4.GetComponent<Button>().currentCondition == buttonCondition.pressed || button5.GetComponent<Button>().currentCondition == buttonCondition.pressed || button6.GetComponent<Button>().currentCondition == buttonCondition.pressed || button7.GetComponent<Button>().currentCondition == buttonCondition.pressed || button8.GetComponent<Button>().currentCondition == buttonCondition.pressed || button9.GetComponent<Button>().currentCondition == buttonCondition.pressed)
        {
            buttonscene2button = scene2button.none;
            button1.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button2.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button3.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button4.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button5.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button6.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button7.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button8.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button9.GetComponent<SpriteRenderer>().sprite = switchOffSprite;
            button1.GetComponent<Button>().currentCondition = buttonCondition.not;
            button2.GetComponent<Button>().currentCondition = buttonCondition.not;
            button3.GetComponent<Button>().currentCondition = buttonCondition.not;
            button4.GetComponent<Button>().currentCondition = buttonCondition.not;
            button5.GetComponent<Button>().currentCondition = buttonCondition.not;
            button6.GetComponent<Button>().currentCondition = buttonCondition.not;
            button7.GetComponent<Button>().currentCondition = buttonCondition.not;
            button8.GetComponent<Button>().currentCondition = buttonCondition.not;
            button9.GetComponent<Button>().currentCondition = buttonCondition.not;
        }

    }

}
