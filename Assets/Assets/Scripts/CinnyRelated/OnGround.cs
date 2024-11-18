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
        isJogging = false; // fix this (1)
    }

    void OnGroundMovement()
    {
        float moveOnX = Input.GetAxis("Horizontal");
        float moveOnZ = Input.GetAxis("Vertical");

        Vector3 baseMovement = new Vector3(moveOnX, 0, moveOnZ) * jogSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + baseMovement);
        isJogging = true; // (2)
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
