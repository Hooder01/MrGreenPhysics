using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private GameObject callPlayer;
    

    void Start()
    {
        callPlayer = GameObject.Find("playerSonic");
        
    }

   
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit Pad?");
    }


    void FixedUpdate()
    {
        
    }
}
