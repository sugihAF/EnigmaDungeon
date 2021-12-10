using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemPuzzle : Interactable
{
    public GameObject obj;
    public GameObject keyItem;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            context.Raise();
            playerInRange = true;
        }else if(other.CompareTag("keyItem")){
            OnKeyItem();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !other.isTrigger)
        {
            context.Raise();
            playerInRange = false;
        }   
    }

    protected virtual void OnKeyItem()
    {
        obj.SetActive(true);
    }

}
