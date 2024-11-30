using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*public class BasicMovement : MonoBehaviour
{
    //Script Ref (make sure you have all the right scripts set up in the inspector)
    public SpeedValues script;
    //

    public GameObject callingJumpBall; 
    public GameObject callingModelSelf; 
    
    private Rigidbody rb;
    
    

    private float baseJump = 5f;
    private bool alreadyInAir;

    void Start()
    {
        callingJumpBall.SetActive(false);
        callingModelSelf.SetActive(true);  
        alreadyInAir = false;
        rb = GetComponent<Rigidbody>();
        
    }

    

    void Movement()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");
      
        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ)* script.BaseSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);

       
        //
        float smoothTurning = 5f; 

        if (movement != Vector3.zero) 
        {
            Quaternion rotateTarget = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, smoothTurning  * Time.deltaTime);
        }
        // Rotation Context
        
    }

    void callingJump()
    {
        
        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(0, baseJump , 0 , ForceMode.Impulse);
            callingModelSelf.SetActive(false);
            callingJumpBall.SetActive(true);
            alreadyInAir = true;
        }
    }

    // PUT THESE TWO IN THE SAME METHOD!

    void homingCancel() // TEMP
    {
        private float fallFoward = 4f;
        if(alreadyInAir == true)
        {
            rb.AddForce(fallFoward, 0 , 0 , ForceMode.Impulse);
            script.BaseSpeed++
            if(script.BaseSpeed > 10)// (will not receive any extra speed)
            {
                Debug.Log("Logic to go here!");
            } 
        }
    }

    

    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Floors")) // Sonic (or the jumpball) looks for the "Floors" tag which has been added to the "Ground" objects in the test world
        {
            callingJumpBall.SetActive(false);
            callingModelSelf.SetActive(true);

            if(script.BaseSpeed >= script.MaxSpeedLimit) // Fix this!!
            {
                script.BaseSpeed--;
            } // (temp momentum)
        }
    }


    void FixedUpdate()
    {
        Movement();
        callingJump();
        homingCancel();
    }
}*/
