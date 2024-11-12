using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicMovement : MonoBehaviour
{
    string[] callBug = { "JumpBall Found!", "JumpBall NOT Found!", "Sonic Mesh Found!", "Sonic Mesh NOT Found!", "Player standing still?", "This Item is not being called" }; // An Array of Debug commands that can be called anywhere (only USE with Debug.Log)

    private float BaseSpeed = 1f; 
    private float acceleration = 1f;
    private float maxCapSpeed = 60f;
    // basic speed values (ONLY change these for easy editing)

    private float jumpForce = 5f;
    private float fallingForce;
    bool isOnGround;
    bool isInAir;
    private GameObject callJumpBall;
    public GameObject callSonicMesh; // had to be made public cause unity!
    //Jumping Context

    private float rollBaseSpeed = 50f; // this should be calucalted along with the base movement
    private float downSlopeSpeed = 10f;  // yet to be used!
    // (change these when needed)
    bool isRolling;
    bool isSlope;
    bool isTopOfSlope;
    //Rolling and SpinDash Context



    private Rigidbody rb; 

    

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        isOnGround = true;
        callJumpBall = GameObject.Find("JumpBall"); 
        callJumpBall.SetActive(false);
        // callSonicMesh isn't needed by default

        isRolling = false;
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

    void CallingRolling()
    {

        // make sure this can only be called during movement!!
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            callJumpBall.SetActive(true);
            callSonicMesh.SetActive(false);
            isRolling = true;

            if (callJumpBall == true && callSonicMesh == false && isRolling == true)
            {
                rb.AddForce(0, rollBaseSpeed, 0, ForceMode.Impulse);
                if(rollBaseSpeed != 50)
                {
                    Debug.Log(callBug[5]);
                }
            }
            else if(callJumpBall == false)
            {
                Debug.Log(callBug[1]); // (FailSafe)
            }
        }
    }

    void CallingJump()
    {
        isOnGround = false;

        if(Input.GetKeyDown("space") && isOnGround == false)
        {
            callSonicMesh.SetActive(false);

            callJumpBall.SetActive(true);
            
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
        
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
        CallingRolling();
        CallingJump();
    }
}
