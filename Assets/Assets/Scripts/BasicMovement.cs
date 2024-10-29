using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class BasicMovement : MonoBehaviour
{
    public float BaseSpeed; // public base speed for sonic that is zero by default 
    public float jumpForce;

    private Rigidbody rb; // calls rigidbody from object and given new data name? 
   
    private float boostSpeed = 5f;
    private float rotateSpeed;

    void Start() 
    {
        rb = GetComponent<Rigidbody>(); 
    }
    
    void Movement()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ) * BaseSpeed * Time.deltaTime;

        if (Input.GetKeyDown("right shift")) // make this hold?
        {
            Debug.Log("Boost active");

            BaseSpeed = boostSpeed; // this works! but now how to bring it back down?
        }

        rb.MovePosition(transform.position + movement);

        
    } // separated function to keep tidy
    

    void Update()
    {

    }

    void FixedUpdate()
    {
        Movement(); // calls movement for use
    }
}
