using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPortalAfterPuzzle : Collidable
{
    public GameObject obj;
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
        obj.SetActive(true);
    }
}
