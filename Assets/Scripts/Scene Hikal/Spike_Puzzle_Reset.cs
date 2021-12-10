using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Puzzle_Reset : Collidable
{
    public Sprite switchOnSprite;
    public Sprite switchOffSprite;
    public GameObject spike1, spike2, spike3, spike4;
    public bool isOn = false;

    protected override void OnCollide(Collider2D coll)
    {
        if (Input.GetKeyDown(KeyCode.Space) && coll.name == "Player")
        {
            isOn = !isOn;

            spike1.SetActive(true);
            spike2.SetActive(true);
            spike3.SetActive(true);
            spike4.SetActive(true);
        }

        if (isOn)
        {
            GetComponent<SpriteRenderer>().sprite = switchOnSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = switchOffSprite;
        }
    }
}
