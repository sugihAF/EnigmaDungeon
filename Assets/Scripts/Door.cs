using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorType
{
    key,
    enemy,
    button
}

public class Door : Interactable
{
    [Header("Door variables")]
    public DoorType thisDoorType;
    public bool open = false;
    public Inventory playerInventory;
    public GameObject door;

    private void Update()
    {
        if(Input.GetButtonDown("attack"))
        {
            if(playerInRange && thisDoorType == DoorType.key)
            {
                //Does the player have a key?
                if(playerInventory.RuntimeValue > 0)
                {
                    //Remove a player key
                    playerInventory.RuntimeValue--;
                    //If so, then call the open method
                    Open();
                }
            }
        }
    }

    public void Open()
    {
        door.SetActive(false);
        //set open to true
        open = true;

    }
}