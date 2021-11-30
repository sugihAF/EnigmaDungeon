using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemPuzzle : Collidable
{
    public GameObject portal;

    protected override void OnCollide(Collider2D coll)
    {
        
        if(coll.name == "Ancient Coin")
        {
            OnKeyItem();
        }
           
    }

    protected virtual void OnKeyItem()
    {
        portal.SetActive(true);
    }
}
