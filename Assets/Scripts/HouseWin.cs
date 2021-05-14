using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseWin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Only win if player collides with house
        GameObject p = collision.gameObject;
        if (p.CompareTag("Player"))
        {
            Debug.Log("You win!");
        }
        
    }
}
