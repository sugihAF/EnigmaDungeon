using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState{
    walk,
    attack,
    interact,
    stagger,
    idle
}
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public PlayerState currentState;

    public Rigidbody2D rb;

    public Animator animator;
    public FloatValue currentHealth;
    public Signal playerHealthSignal;
    public Inventory playerInventory;
    public SpriteRenderer receivedItemSprite;

    Vector3 movement;
    void Start(){
        currentState = PlayerState.walk;
    }
    void Update()
    {
        if(currentState == PlayerState.interact){
            return;
        }
        movement = Vector3.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if(Input.GetButtonDown("attack") && currentState != PlayerState.attack && currentState != PlayerState.stagger)
        {
            StartCoroutine(AttackCo());
        }
        else if(currentState == PlayerState.walk || currentState == PlayerState.idle)
        {
            UpdateAnimationAndMove();
        }
    }
    private IEnumerator AttackCo()
    {
        animator.SetBool("Attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        animator.SetBool("Attacking", false);
        yield return new WaitForSeconds(.3f);
        if(currentState != PlayerState.interact){
            currentState = PlayerState.walk;
        }
    }

    public void RaiseItem(){
        if(playerInventory.currentItem != null){
            if(currentState != PlayerState.interact){
                animator.SetBool("recieveItem",true);
                currentState = PlayerState.interact;
                receivedItemSprite.sprite = playerInventory.currentItem.itemSprite;
            }else{
                animator.SetBool("recieveItem",false);
                currentState = PlayerState.idle;
                receivedItemSprite.sprite = null;
                playerInventory.currentItem=null;
            }
        }
    }

    void UpdateAnimationAndMove(){
        if(movement != Vector3.zero){
            MoveCharacter();
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
        }
    }
    void MoveCharacter()
    {
        movement.Normalize();
        rb.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime); 
    }
     public void Knock(float knockTime, float damage)
    {
        currentHealth.RuntimeValue -= damage;
        playerHealthSignal.Raise();
        if(currentHealth.RuntimeValue > 0){

            StartCoroutine(KnockCo(knockTime));
        }else{
            this.gameObject.SetActive(false);
        }
    }

    private IEnumerator KnockCo(float knockTime)
    {
        if (rb != null)
        {
            yield return new WaitForSeconds(knockTime);
            rb.velocity = Vector2.zero;
            currentState = PlayerState.idle;
            rb.velocity = Vector2.zero;
        }
    }
}


