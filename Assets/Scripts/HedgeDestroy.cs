using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedgeDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Remove hedge when all coins collected
        if (CoinCounter.counter == 3)
        {
            Destroy(gameObject);
        }
    }
}
