using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGuards : MonoBehaviour
{
    // Guard to generate
    public GameObject GuardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn guards at desired positions
        Instantiate(GuardPrefab, new Vector2(-4, 3), Quaternion.identity);
        Instantiate(GuardPrefab, new Vector2(0, 3), Quaternion.identity);
        Instantiate(GuardPrefab, new Vector2(4, 3), Quaternion.identity);
        Instantiate(GuardPrefab, new Vector2(-2, -3), Quaternion.identity);
        Instantiate(GuardPrefab, new Vector2(2, -3), Quaternion.identity);   
    }

}
