using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum switchCondition{
    pressed,
    not
}
public class Switch : Collidable
{
    public GameObject otherObject;
    public switchCondition currentCondition;
    public Sprite otherObjectChangeSprite;
    public Sprite switchOnSprite;
    BoxCollider2D box2d;
    
    // Start is called before the first frame update
    protected override void OnCollide(Collider2D coll)
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && coll.name == "Player")
        {
            GetComponent<SpriteRenderer>().sprite = switchOnSprite;
            SwitchInteract();
            currentCondition = switchCondition.pressed;
        }
           
    }

    protected virtual void SwitchInteract()
    {
        otherObject.GetComponent<SpriteRenderer>().sprite = otherObjectChangeSprite;
        box2d = otherObject.GetComponent<BoxCollider2D>();
        box2d.enabled = false;
    }
}
