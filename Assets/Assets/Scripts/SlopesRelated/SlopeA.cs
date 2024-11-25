using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeA : MonoBehaviour
{
    public float dynFriction;
    public float statFriction;
    private Collider coll;
    bool playerTouched;

    void Start() 
    {
        coll = GetComponent<Collider>();
        coll.material.dynamicFriction = dynFriction;
        coll.material.staticFriction = statFriction;
        playerTouched = false;
    }

    void OnCollisionEnter() // (Debug Message)
    {
        playerTouched = true;
        if(playerTouched == true)
        {
            Debug.Log("Friction Found!"); 
        }
    }

    // This controls Sonic/Player Friction for slopes (more needs to be done on "Basic Movement" that require jumping at certain angles)
}
