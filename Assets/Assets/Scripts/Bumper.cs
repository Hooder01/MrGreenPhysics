using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public GameObject player; // asks for player ref
    Vector3 bounceForce;

    bool hasplayerTouched = false; // ???

    void Start()
    {
        bounceForce = new Vector3(0.0f, 0.0f, 0.0f);
    }

    void FixedUpdate()
    {
        
    }
}
