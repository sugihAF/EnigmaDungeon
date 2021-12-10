using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Chest : Interactable
{
    public Item contents;
    public Inventory playerInventory;
    public bool isOpen;
    public Signal raiseItem;
    public GameObject dialogBox;
    public Text dialogText;
    public Sprite chestOpened;

    private void Start()
    {
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {

            if(!isOpen){
                //Buka Chest
                OpenChest();
            }else{
                //chest udah terbuka
                ChestOpened();
            }
        }
    }
    public void OpenChest(){
        dialogBox.SetActive(true);
        dialogText.text = contents.description;
        playerInventory.AddItem(contents);
        playerInventory.currentItem = contents;
        isOpen = true; 
        raiseItem.Raise();
        context.Raise();
        GetComponent<SpriteRenderer>().sprite=chestOpened;
    }
    public void ChestOpened(){

        dialogBox.SetActive(false);
        raiseItem.Raise();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = false;
        }
    }

}
