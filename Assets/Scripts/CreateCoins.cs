using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCoins : MonoBehaviour
{
    // Coin to generate
    public GameObject CoinPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        // Generate coins at desired positions
        Instantiate(CoinPrefab, new Vector2(-5, 4), Quaternion.identity);
        Instantiate(CoinPrefab, new Vector2(0, 4), Quaternion.identity);
        Instantiate(CoinPrefab, new Vector2(5, 4), Quaternion.identity);
    }

}
