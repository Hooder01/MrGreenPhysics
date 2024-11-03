using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Note for future Ref
You do not need to use RigidBody when already ref the player through OnCollisionEnter (I think)*/

public class Bumper : MonoBehaviour
{
    public GameObject player;
    
    public float bounceForce; // be sure to set this in the very lows
    bool lockcontrol =  false; // will lock sonic control temp in the mist of the bounce taking place

    int speedmaxcheck; // this will be used later, depending on sonics speed the bounce will be diffrent

    void Start()
    {
         player = GameObject.Find("playerSonic"); // Unity looks for Sonics gameobject
        
         
    }


    void OnCollisionEnter(Collision collision) // OnCollisonEnter is a function within unity that let's diffrent rigidbodys interact (this works as long as the object in question has a rb)
    {
        Debug.Log("Is working?");

        
        
    }

    void FixedUpdate()
    {
        
    }
}
