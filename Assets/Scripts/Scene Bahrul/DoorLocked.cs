using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TypeDoor
{
    key,
    enemy,
    button
}
public class DoorLocked : Interactable
{
    [Header("Door variables")]
    public TypeDoor thisDoorType;
    public bool open = false;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public Inventory playerInventory;
    public GameObject door;

    private void Update()
    {
        if (Input.GetButtonDown("attack"))
        {
            if (playerInRange && thisDoorType == TypeDoor.key)
            {
                //Does the player have a key?
                if (playerInventory.RuntimeValue > 0)
                {
                    //Remove a player key
                    playerInventory.RuntimeValue--;
                    //If so, then call the open method
                    Open();
                }
                else
                {
                    if (dialogBox.activeInHierarchy)
                    {
                        dialogBox.SetActive(false);
                    }
                    else
                    {
                        dialogBox.SetActive(true);
                        dialogText.text = dialog;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            context.Raise();
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            context.Raise();
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }

    public void Open()
    {
        door.SetActive(false);
        //set open to true
        open = true;

    }
}
