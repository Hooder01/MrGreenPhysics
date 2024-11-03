using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBounds : MonoBehaviour
{

    private GameObject callPlayer; // 1!

    void Start()
    {
        callPlayer = GameObject.Find("playerSonic"); // 2!
    }

    void OnCollisionEnter(Collision collision) // 3!
    {
        Debug.Log("Player Dead?");
        Destroy(callPlayer);

        // needs to respawn sonic after
    }

    // will destroy player/kill on contact (context if player goes outta bounds) 
}
