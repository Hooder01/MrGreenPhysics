using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicMovement : MonoBehaviour
{
    string[] callBug = { "JumpBall Found!", "JumpBall NOT Found!", "Sonic Mesh Found!", "Sonic Mesh NOT Found!", "This Item is not being called", "this item is working!" }; // An Array of Debug commands that can be called anywhere (only USE with Debug.Log)

    private float BaseSpeed = 1f; 
    private float acceleration = 1f;
    private float maxCapSpeed = 60f;
    // basic speed values (ONLY change these for easy editing)

    private float sonicMassOnAverage;
    private float gravityPullAverage = -9.0f;
    // (Physics also for easy editing) // MAKE THIS PUBLIC FOR DEMO?



    private Rigidbody rb; 

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = sonicMassOnAverage;

        Physics.gravity = new Vector3(0, gravityPullAverage, 0);
    }

    

    void Movement()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ) * BaseSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);

        BaseSpeed += acceleration * Time.deltaTime;

        if(BaseSpeed > maxCapSpeed)
        {
            BaseSpeed = maxCapSpeed;
        }
        // return to a base speed?

        

        if (movement != Vector3.zero) // Makes sure that movement is always using Vector3
        {
            Quaternion rotateTarget = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, 5 /*edit this number for smooth turning*/ * Time.deltaTime);
        }
        // rotates Sonic to the pressed input in question


        
        // Looks for Sonics Physics in the air and how it should drop him (Look for "Calling Jump" below!)
    }



    void OnCollisionEnter(Collision collision)
    {
        // slope collision to go here ( I think? )
    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement();
    }
}
