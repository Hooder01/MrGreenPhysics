using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicMovement : MonoBehaviour
{
    private float BaseSpeed = 1f; // public base speed for sonic that is zero by default (may or may not make private in the future)
    private float acceleration = 1f;
    private float maxCapSpeed = 90f;

    private float jumpForce = 5f;
    bool isOnGround;
    private GameObject callJumpBall;
    private GameObject callSonicMesh;

    // a public gameobject for dectecting when going down slopes!
    
    private Rigidbody rb; // calls rigidbody from object and given new data name? 

    

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        isOnGround = true;
        callJumpBall = GameObject.Find("JumpBall"); 
        callJumpBall.SetActive(false);

        callSonicMesh = GameObject.Find("Sonic");
        // Set Active by deafult?

        
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
            callJumpBall.SetActive(true);
            callSonicMesh.SetActive(false);
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
        
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Slope Collison here!");
    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement(); 
        CallingJump();
    }
}
