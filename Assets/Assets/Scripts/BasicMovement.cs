using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDashANDRolling // should we make this a class?
{

}

public class BasicMovement : MonoBehaviour
{
    private float BaseSpeed = 1f; // public base speed for sonic that is zero by default (may or may not make private in the future)
    private float acceleration = 1f;
    private float maxCapSpeed = 60f;

    private float jumpForce = 5f;
    bool isOnGround;
    private GameObject callJumpBall;
    public GameObject callSonicMesh; // had to be made public cause unity!

    // a public gameobject for dectecting when going down slopes!
    
    private Rigidbody rb; // calls rigidbody from object and given new data name? 

    struct RollingValues
    {
        private GameObject callingSlopes; // Will be used to identify certain geometry (possible via a tag but no clue yet)
        private float rollBaseSpeed; // (no value! don't forget you twat)

        if(Input.GetKeyDown("left shift")) // THE FUCK!? 

        // no if statments in structs dumb dumb!

    }

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        isOnGround = true;
        callJumpBall = GameObject.Find("JumpBall"); 
        callJumpBall.SetActive(false);
        // callSonicMesh isn't needed by default
    }

     void RollingMovement()
    {
        // Rolling Physcis will happen here (this call only be called during movement!)
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
        CallingJump();
    }
}
