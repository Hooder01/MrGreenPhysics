using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundControl : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    

    public GlobalValues script;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator.GetComponent<Animator>();
    }

    
    void baseOnGround()
    {
        float transX = Input.GetAxis("Horizontal");
        float transZ = Input.GetAxis("Vertical");

        Vector3 baseMovement = new Vector3(transX, 0 , transZ) * script.baseSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + baseMovement);

        float smoothTurning = 5f; 

        if (baseMovement != Vector3.zero) 
        {
            Quaternion rotateTarget = Quaternion.LookRotation(baseMovement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, smoothTurning  * Time.deltaTime);
        }
        
        script.baseSpeed += script.accelerationSpeed  * Time.deltaTime;
        // (Putting these two in a addition assignment operator then multiplyed in each updated frame)

        
        if(script.baseSpeed == script.topSpeed)
        {
            Debug.Log("working?"); // call a stronger mass
        }
        
    }

   void OnCollisionEnter(Collision collision) 
   {
        if(collision.gameObject.CompareTag("DeathZone"))
        {
            script.baseSpeed = 0;
        }

        if(collision.gameObject.CompareTag("Floors"))
        {
            script.modelSelf.SetActive(true);
        }
        
   } // ( TEMP ) // this is bad code (will fix at a later date!)

    void FixedUpdate()
    {
        baseOnGround();
    }
}
