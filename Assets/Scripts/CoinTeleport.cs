using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTeleport : MonoBehaviour
{
    // Tag of object to teleport on collision
    public string targetTag = "Player";
    Rigidbody2D rb;
    
    // Called when this object collides with another
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get reference to other game object from parameter
        GameObject other = collision.gameObject;

        // If it has the tag we are looking for, teleport it to location
        if (other.CompareTag(targetTag))
        {
            // Get and store physics component
            rb = GetComponent<Rigidbody2D>();

            // Generate random values for x, y
            float x = Random.Range(-0.5f, 0.5f);
            float y = Random.Range(-3.5f, -2.5f);

            // Use to create Vector2 and store as new position
            rb.position = new Vector2(x, y);

            // Increase coin counter
            CoinCounter.counter++;
        }
    }
}
