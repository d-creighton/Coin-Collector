using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    Rigidbody2D rb;                     // This object's Rigidbody
    SpriteRenderer spriteRenderer;      // This object's SpriteRenderer
    float distancePerSecond = 0.75f;    // Guard speed
    bool chasePlayer = false;           // Determine if player close enough to be chased

    public static bool guardCaught = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get Rigidbody and SpriteRenderer
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chasePlayer)
        {
            GameObject p = GameObject.FindWithTag("Player");    // p = player
            if (p == null) return;

            Rigidbody2D prb = p.GetComponent<Rigidbody2D>();      // prb = player Rigidbody

            // Move toward player
            Vector2 delta = prb.position - rb.position;
            delta.Normalize();
            rb.position += delta * distancePerSecond * Time.deltaTime;
            
            // Face sprite in direction of player
            spriteRenderer.flipX = (rb.position.x < prb.position.x);
            
        }
    }

    // Trigger movement
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if object collided with is player
        GameObject p = collision.gameObject;
        if (p.CompareTag("Player"))
        {
            // Start moving toward player
            chasePlayer = true;
        }
    }

    // Stop movement
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject p = collision.gameObject;
        if (p.CompareTag("Player"))
        {
            // Stop moving toward player
            chasePlayer = false;
        }
    }

    // Determining if a player is caught
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject p = collision.gameObject;
        if (p.CompareTag("Player"))
        {
            // Player is caught
            guardCaught = true;
            chasePlayer = false;
        }
        
    }
}
