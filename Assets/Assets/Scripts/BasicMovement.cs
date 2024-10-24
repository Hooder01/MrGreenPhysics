using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class BasicMovement : MonoBehaviour
{
    public float BaseSpeed; // public base speed for sonic that is zero by default 

    void Start() 
    {
        Rigidbody rb = GetComponent<Rigidbody>(); // calls for Rigidbody and gives a new component (I think?)
    }
    
    void FixedUpdate()
    {
        
    }
}
