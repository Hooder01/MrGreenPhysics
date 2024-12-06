using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airControl : MonoBehaviour
{
    
    public GlobalValues script;
    private Rigidbody rb;
    private bool playerInAir;

    void Start()
    {
        script.callingJumpBall.SetActive(false);

        rb = GetComponent<Rigidbody>();
    }

    void inAirControl()
    {
        script.jumpForce = 6.1f;

        if(Input.GetKeyDown("space") & !playerInAir)
        {
            rb.AddForce(transform.up * script.jumpForce, ForceMode.Impulse);
            
            playerInAir = true;
        }
    }

    void OnCollisionEnter(Collision collision) 
   {
        if(collision.gameObject.CompareTag("Floors"))
        {
            
            playerInAir = false;
        }
        
   } 

    void Update()
    {
        inAirControl();
    }
}
