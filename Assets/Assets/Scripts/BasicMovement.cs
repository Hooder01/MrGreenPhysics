using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBallTEMP // just keeping the jump ball in here for now for the sake of my eyes
{
    /*public GameObject callJumpBall; // jumpball context1
    bool isJumpBallActive; // jumpball context2 (this will check in context very often!)*/

    /*callJumpBall = GameObject.Find("JumpBall"); // jumpball context3
        Destroy(callJumpBall);*/
}

public class BasicMovement : MonoBehaviour
{
    private float BaseSpeed = 1f; // public base speed for sonic that is zero by default (may or may not make private in the future)
    private float acceleration = 1f;
    private float maxCapSpeed = 130f;

    // a public gameobject for dectecting when going down slopes!
    
    private Rigidbody rb; // calls rigidbody from object and given new data name? 

    private Animator SonicAnim;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        SonicAnim = GetComponent<Animator>();

        SonicAnim.SetTrigger("TriggerIdle"); // this is not working!!
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
  

    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement(); 
    }
}
