using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSonicOnTrigger : MonoBehaviour
{
    
    public GameObject onTrigger;
    public GameObject camSelf;
    public GameObject offTrigger;

     struct camSets // a struct holding the cam values (edit these values at ease)
    {
        int camX;
        int camY;
        int camZ;
    }

    void Start()
    {
        camSets point = new camSets(); // FIX THIS!!
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Boost Section Active");
        
    }
    
}


/* Will Snap the player cam in the direction untill out of the trigger

 (Everything set to public but will all be changed to private on a future update)*/