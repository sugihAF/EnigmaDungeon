using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffObstacle : Collidable
{
    public GameObject obstacle;
    public GameObject keyItem;
    
    protected override void OnCollide(Collider2D coll)
    {
        
        if(coll.name == keyItem.name)
        {
            OnKeyItem();
        }
           
    }

    protected virtual void OnKeyItem()
    {
        obstacle.SetActive(false);
    }
}
