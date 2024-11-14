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
    private float gravityPullAverage = -5.0f;
    // (Gravity also for easy editing) // MAKE THIS PUBLIC FOR DEMO?

    private float BaseJump =  5; // (Edit this if you don't like the feeling of the jump)
    public GameObject callingJumpBall; // This asks for the Jumpball model in the inspector (it can be called via private but you need to declare .find in Start() )
    public GameObject callingModelSelf; // same as Jumpball but for the use of Sonics model (this may not be needed depending on how the booleans want to behave)
    bool isJumpBallActive;
    // (all jumping related, DO NOT REMOVE THESE BOOLEANS!)

    private Rigidbody rb; 

    

    void Start()
    {
        callingModelSelf.SetActive(true); // (This should always be true on default)

        rb = GetComponent<Rigidbody>();
        rb.mass = sonicMassOnAverage;

        Physics.gravity = new Vector3(0, gravityPullAverage, 0); // (Jump not working because of the gravity!?)

        // 
        isJumpBallActive = false;
        callingJumpBall.SetActive(false);

        // (DO NOT EDIT THESE!)
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

    void jumpCalling()
    {
        
        isJumpBallActive = true;

        if(Input.GetKeyDown("space") && isJumpBallActive == true)
        {
            Debug.Log(callBug[5]);
            rb.AddForce(transform.up * BaseJump, ForceMode.Impulse);
        }
    }   

    void OnCollisionEnter(Collision collision)
    {
        // slope collision to go here ( I think? )
    }


    void Update()
    {
        // (this is most likey never needed if the case of Sonic)
    }

    void FixedUpdate()
    {
        Movement();
        jumpCalling(); // (this could be temp)
    }
}
