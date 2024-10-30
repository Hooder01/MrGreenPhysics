using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class BasicMovement : MonoBehaviour
{
    public float BaseSpeed; // public base speed for sonic that is zero by default (may or may not make private in the future)
    public float jumpForce;

    private Rigidbody rb; // calls rigidbody from object and given new data name? 
   
    /*private float boostSpeed = 5f;*/
    

    void Start() 
    {
        rb = GetComponent<Rigidbody>(); // still have no fucking clue what this bit means tbh
    }
    
    void Movement()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ) * BaseSpeed * Time.deltaTime;

        /*if (Input.GetKeyDown("right shift")) // make this hold?
        {
            Debug.Log("Boost active");

            BaseSpeed = boostSpeed; // this works! but now how to bring it back down?
        }*/

        rb.MovePosition(transform.position + movement);


        if(movement != Vector3.zero) // Makes sure that movement is always using Vector3
        {
            Quaternion rotateTarget = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, 10 * Time.deltaTime);
        }
        // rotates Sonic to the pressed input in question
        
    } // separated function to keep tidy
    

    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement(); // calls movement as a function for use
    }
}
