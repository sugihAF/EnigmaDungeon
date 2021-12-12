using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPosition : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = destination.transform.position;
            Teleport(collision);
        }
    }

    private void Start()
    {
        rb = rb.GetComponent<Rigidbody2D>();
    }
    private void Teleport(Collider2D other)
    {
        rb.MovePosition(other.transform.position);
        
    }


}
