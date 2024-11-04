using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicMovement : MonoBehaviour
{
    public float BaseSpeed; // public base speed for sonic that is zero by default (may or may not make private in the future)

    private float jumpForce = 4f; // Jumping1
    bool isInAir = true; // jumping2
    public GameObject callJumpBall; // jumpball context1
    bool isJumpBallActive = false; // jumpball context2 (this will check in context very often!)

    private Rigidbody rb; // calls rigidbody from object and given new data name? 
    private Animation anim;

    


    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Grabs the rigidbody from within unity
        anim = gameObject.GetComponent<Animation>();

        callJumpBall = GameObject.Find("JumpBall"); // jumpball context3
        Destroy(callJumpBall); 

        // Somehow set up the boolean with the jumpball being destroy (same applies in the if statment)
    }

    void Movement()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ) * BaseSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);


        if (movement != Vector3.zero) // Makes sure that movement is always using Vector3
        {
            Quaternion rotateTarget = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, 5 /*edit this number for smooth turning*/ * Time.deltaTime);
        }
        // rotates Sonic to the pressed input in question
    }
  
    void onJump()
    {
        if (Input.GetKeyDown("space") && isInAir)
        {
            Debug.Log("Pressed!");

            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse); // always make sure to add ForceMode!

            isJumpBallActive = true; // jumpball context4

            if(isJumpBallActive = true) // jumpball context5
            {
                Debug.Log("JumpBall is being called!"); // good this works!
                
                // how can we make the main player model go away temp?
            }
        }
        //Forces Sonic to Jump into the air in Y postion on spacebar
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement(); // calls movement as a function for use
        onJump();
        
    }
}
