using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPhysics : MonoBehaviour
{

    string[] callBug = {"JumpBall Found!", "JumpBall NOT Found!", "Sonic Mesh Found!", "Sonic Mesh NOT Found!", "Player standing still?"}; // An Array of Debug commands that can be called anywhere (only USE with Debug.Log)


    private GameObject JumpBallMesh; 
    private Rigidbody rb;

    private float rollBaseSpeed = 8f; 
    private float downSlopeSpeed = 10f;  // yet to be used!
    // (change these when needed)
    bool isRolling;

    void Start()
    {
        JumpBallMesh = GameObject.Find("JumpBall"); // we can't use this in a sepreate script???
        /*JumpBallMesh.SetActive(false);*/
        isRolling = false;

        rb = GetComponent<Rigidbody>(); // Grabs Physics of Sonic
    }


    void CallingRolling()
    {

        // make sure this can only be called during movement!!
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            /*JumpBallMesh.SetActive(true);
            if(JumpBallMesh == true)
            {
                Debug.Log(callBug[0]);
            }
            else
            {
                Debug.Log(callBug[1]);
            }*/
        }
    }


    void FixedUpdate()
    {
        CallingRolling();
    }
}
