using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    // Calling Objects
    public GameObject pathPoint; 
    private Rigidbody rb;
    private GameObject callingPlayer;

    // Floats
    private float baseSpeed;
    private float speedWhenSpotted;
    //Booleans
    bool isPlayerSpotted;
    bool followPath;

    private void Start()
    {
        baseSpeed = 5f;
        isPlayerSpotted = false;

        callingPlayer = GameObject.Find("playerSonic");

        
    }

    

    void OnCollisionEnter()
    {
        
    }



    private void FixedUpdate()
    {
        
    }
}
