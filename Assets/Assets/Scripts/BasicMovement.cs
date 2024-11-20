using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class MassAndPhys
{
    private float sonicMassOnAverage;
    private float gravityPullAverage = -5.0f;
    // (Gravity also for easy editing) (CURRENT NOT IN USE!)
}*/

public class BasicMovement : MonoBehaviour
{
    string[] callBug = { "JumpBall Found!", "JumpBall NOT Found!", "Sonic Mesh Found!", "Collision Found!", "This Item is not being called", "this item is working!" }; // An Array of Debug commands that can be called anywhere (only USE with Debug.Log)

    public float BaseSpeed = 1f; 
    private float acceleration = 1f;
    private float maxCapSpeed = 60f;
    // basic speed values (ONLY change these for easy editing)

    

    private float BaseJump =  5; // (Edit this if you don't like the float of the jump)
    public GameObject callingJumpBall; //(set these both to private in the future)
    public GameObject callingModelSelf; //
    bool isOnGround;
    float ballcenter = 0.0f;
    float ballradius = 0.5f;
    // (all jumping related, DO NOT REMOVE THESE BOOLEANS!)

    private Rigidbody rb; 


    void Start()
    {
        
        callingJumpBall.SetActive(false);
        callingModelSelf.SetActive(true); 
        isOnGround = true;
        
        
        //MassAndPhys classObject = new MassAndPhys(); // (calling public Mass and Physics class)

        rb = GetComponent<Rigidbody>();

        //rb.mass = sonicMassOnAverage;

        //Physics.gravity = new Vector3(0, gravityPullAverage, 0); // (This is called off since it intefears with jumpCalling atm)
        
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

        

        if (movement != Vector3.zero) 
        {
            Quaternion rotateTarget = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, 5 /*edit this number for smooth turning*/ * Time.deltaTime);
        }
        // rotates Sonic to the pressed input in question

        //
        
    }


    void callingJump()
    {
        if(Input.GetKeyDown("space"))
        {
            isOnGround = false; // this dosesn't do anything (fix that)
            
            rb.AddForce(0, BaseJump , 0 , ForceMode.Impulse); 
            callingJumpBall.SetActive(true);
            callingModelSelf.SetActive(false);
            if(Input.GetKeyDown("space") & Input.GetKeyDown("space")) // (if player tries to double jump)
            {
                Debug.Log(callBug[5]);
            }
        }
    }

    void OnCollisionEnter(Collision collision) // Sonic can now collide with anything (as long as he has his colider attached)
    {
        if(collision.gameObject.CompareTag("Floors")) // Sonic (or the jumpball) looks for the "Floors" tag which has been added to the "Ground" objects in the test world
        {
            Debug.Log(callBug[3]); 
            isOnGround = true;
            callingModelSelf.SetActive(true);
            callingJumpBall.SetActive(false);

            if(isOnGround != true && callingJumpBall != false && callingModelSelf == true)
            {
                Debug.Log(callBug[4]); // (FailSafe)
                // restart scene!
            }
        }
    }


    void FixedUpdate()
    {
        Movement();
        callingJump();
        
    }
}
