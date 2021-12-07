using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum buttonCondition{
    not,
    pressed
}
public class Button : Collidable
{
    public buttonCondition currentCondition = buttonCondition.not;
    public Sprite switchOnSprite;
    public Sprite switchOffSprite;
    BoxCollider2D box2d;
    
    // Start is called before the first frame update
    protected override void OnCollide(Collider2D coll)
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && coll.name == "Player")
        {
            if(currentCondition == buttonCondition.not){
                GetComponent<SpriteRenderer>().sprite = switchOnSprite;
                currentCondition = buttonCondition.pressed;
            }else if(currentCondition == buttonCondition.pressed){
                GetComponent<SpriteRenderer>().sprite = switchOffSprite;
                currentCondition = buttonCondition.not;
            }
            
        }
           
    }
}
