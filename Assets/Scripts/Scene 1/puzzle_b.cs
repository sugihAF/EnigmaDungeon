using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_b : Collidable
{
    public Sprite switchOnSprite;
    public GameObject other;
    // Start is called before the first frame update
    protected override void OnCollide(Collider2D coll)
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && coll.name == "Player")
        {
            GetComponent<SpriteRenderer>().sprite = switchOnSprite;
            other.SetActive(false);
        }
           
    }
}
