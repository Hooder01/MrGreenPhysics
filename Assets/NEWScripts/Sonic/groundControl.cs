using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundControl : MonoBehaviour
{
    private Rigidbody rb;

    public GlobalValues script;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void baseOnGround()
    {
        float transX = Input.GetAxis("Horizontal");
        float transZ = Input.GetAxis("Vertical");

        Vector3 baseMovement = new Vector3(transX, 0 , transZ) * script.baseSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + baseMovement);

        //
        float smoothTurning = 5f; 

        if (baseMovement != Vector3.zero) 
        {
            Quaternion rotateTarget = Quaternion.LookRotation(baseMovement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, smoothTurning  * Time.deltaTime);
        }
        // Rotation Context
        
    }


    void FixedUpdate()
    {
        baseOnGround();
    }
}
