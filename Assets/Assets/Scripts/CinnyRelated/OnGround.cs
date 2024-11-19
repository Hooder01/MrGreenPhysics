using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{

    private Rigidbody rb;
    private float jogSpeed = 2.5f;
    private float SprintSpeed;
    private float jumpForce;
    private float gravityForce;

    
     bool isJogging;
     
    

    // what abilities does Cinny have compared too Sonic?

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void OnGroundMovement()
    {
        float moveOnX = Input.GetAxis("Horizontal");
        float moveOnZ = Input.GetAxis("Vertical");

        Vector3 baseMovement = new Vector3(moveOnX, 0, moveOnZ) * jogSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + baseMovement);
        
        if(baseMovement != Vector3.zero)
        {
            Quaternion rotateTarget = Quaternion.LookRotation(baseMovement);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotateTarget, 5 * Time.deltaTime);
        }
    }
    
    void OnSprintMovement()
    {
        if(Input.GetKeyDown("right shift") && isJogging == true) // (3)
        {
            Debug.Log("pressed!");
        }
    }
    
    public void FixedUpdate()
    {
        OnGroundMovement();
        OnSprintMovement();
    }
}
