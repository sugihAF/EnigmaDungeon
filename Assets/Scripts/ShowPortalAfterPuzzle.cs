using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemPuzzle : Collidable
{
    public GameObject portal;
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
        portal.SetActive(true);
    }
}
