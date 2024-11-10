using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicMovement : MonoBehaviour
{
    private float BaseSpeed = 1f; 
    private float acceleration = 1f;
    private float maxCapSpeed = 60f;
    // basic speed values (ONLY change these for easy editing)

    private float jumpForce = 5f;
    bool isOnGround;
    private GameObject callJumpBall;
    public GameObject callSonicMesh; // had to be made public cause unity!
    //Jumping Context



    private GameObject callingSlopes; // Will be used to identify certain geometry (possible via a tag but no clue yet)
    struct RollingCalculations
    {
         float rollBaseSpeed = 8f;
         float topOfSlopeAverage;
         float slopeCalculations;

        // slopes could be handeled by Tags?
    }
    //Rolling&&SpinDash Context



    private Rigidbody rb; 

    

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        isOnGround = true;
        callJumpBall = GameObject.Find("JumpBall"); 
        callJumpBall.SetActive(false);
        // callSonicMesh isn't needed by default
    }

    void CallingRolling()
    {

        // make sure this can only be called during movement!!
        if(Input.GetKeyDown("left shift"))
        {
            callSonicMesh.SetActive(false);
            callJumpBall.SetActive(true);

            rb.AddForce(0, 0, rollBaseSpeed, ForceMode.Impulse);
            // add if statement looking for "slope tag" here!
        }
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
        else if(Input.GetKeyDown("space") && Input.GetKeyDown("space") && isOnGround == false)
        {
            Debug.Log("Send Sonic Foward via dash");
            // this not being called?
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
