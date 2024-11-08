using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBounds : MonoBehaviour
{

    private GameObject callPlayer; // 1!
    bool isScreenFaded;

    void Start()
    {
        callPlayer = GameObject.Find("playerSonic"); // 2!
        isScreenFaded = false;
    }

    void OnCollisionEnter(Collision collision) // 3!
    {
        Debug.Log("call for reaspawn!");

        callPlayer.transform.position = new Vector3(0, 1, 0);

        
    }

    // will destroy player/kill on contact (context if player goes outta bounds) 
}
