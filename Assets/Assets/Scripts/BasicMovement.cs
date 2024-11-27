using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Most of this is really sh*t code that needs re done

public class BasicMovement : MonoBehaviour
{
    string[] callBug = { "JumpBall Found!", "JumpBall NOT Found!", "Sonic Mesh Found!", "Collision Found!", "This Item is not being called", "this item is working!" }; // An Array of Debug commands that can be called anywhere (only USE with Debug.Log)

    public float BaseSpeed = 1f; 
    //public float MoveAccell = 1f;
    //private float TopSpeed = 55f;
    

    private float BaseJump =  1; // (Edit this if you don't like the float of the jump)
    public GameObject callingJumpBall; //(set these both to private in the future)
    public GameObject callingModelSelf; //
    
    private Rigidbody rb; 
    


    void Start()
    {
        callingJumpBall.SetActive(false);
        callingModelSelf.SetActive(true);  

        rb = GetComponent<Rigidbody>();
        Homing.airDash();
    }

    

    void Movement()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ) * BaseSpeed * Time.deltaTime;

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
            rb.AddForce(0, BaseJump , 0 , ForceMode.Impulse);
            callingModelSelf.SetActive(false);
            callingJumpBall.SetActive(true);
            
            if(isPlayerInAir = true)
            {
                Debug.Log("Active");
            }
        }
    }

    void OnCollisionEnter(Collision collision) // Sonic can now collide with anything (as long as he has his colider attached) (quite a good chunk of this could be changed)
    {
        if(collision.gameObject.CompareTag("Floors")) // Sonic (or the jumpball) looks for the "Floors" tag which has been added to the "Ground" objects in the test world
        {
            callingJumpBall.SetActive(false);
            callingModelSelf.SetActive(true);
        }
    }


    void FixedUpdate()
    {
        Movement();
        callingJump();
        
    }
}
