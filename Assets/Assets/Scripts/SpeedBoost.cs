using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private GameObject callPlayer;
    

    // (General Settings)
    bool playertouched; 
    private Rigidbody rb;

    
    

    void Start()
    {
        callPlayer = GameObject.Find("playerSonic"); // (Finds Sonic)
        callPlayer.GetComponent<BasicMovement>().BaseSpeed = 1f; // (calling for Sonics Script Ref)


        rb = GetComponent<Rigidbody>();
    }

    

   
    void OnCollisionEnter(Collision collision)
    {
        
    }


    
}
