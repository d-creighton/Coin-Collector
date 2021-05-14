using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float distancePerSecond = 1.5f;
    bool doubleSpeed = false;               // Power up

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Amount to move in each dimension
        float dx = 0;
        float dy = 0;

        if (!GuardMovement.guardCaught)
        {
            // Move up
            if (Input.GetKey (KeyCode.UpArrow)) {
                dy = distancePerSecond * Time.deltaTime;
            }
            // Move down
            if (Input.GetKey (KeyCode.DownArrow)) {
                dy = -distancePerSecond * Time.deltaTime;
            }
            // Move left
            if (Input.GetKey (KeyCode.LeftArrow)) {
                dx = -distancePerSecond * Time.deltaTime;
            }
            // Move right
            if (Input.GetKey (KeyCode.RightArrow)) {
                dx = distancePerSecond * Time.deltaTime;
            }
            // Move by that amount
            rb.position += new Vector2(dx, dy);

            // Power up only usable once
            if (!doubleSpeed)
            {
                // Press z to double the player movement speed
                if (Input.GetKeyDown("z"))
                {
                    distancePerSecond = (distancePerSecond*2);
                    doubleSpeed = true;
                }
            }
        }
        
    }
}
