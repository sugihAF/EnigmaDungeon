using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Puzzle_2 : Collidable
{
    public Sprite switchOnSprite;
    public Sprite switchOffSprite;
    public GameObject spike1, spike2;
    public bool isOn = false;

    protected override void OnCollide(Collider2D coll)
    {
        if(Input.GetKeyDown(KeyCode.Space) && coll.name == "Player")
        {
            isOn = !isOn;

            spike1.SetActive(!spike1.activeSelf);
            spike2.SetActive(!spike2.activeSelf);
        }

        if(isOn)
        {
            GetComponent<SpriteRenderer>().sprite = switchOnSprite;
        } else
        {
            GetComponent<SpriteRenderer>().sprite = switchOffSprite;
        }
    }
}
