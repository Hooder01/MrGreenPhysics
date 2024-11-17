using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{

    private RigidBody rb;
    private float jogSpeed;
    private float onSprintSpeed;
    private float jumpForce;
    private float gravityForce;

    public struct BooleanObjects // remember to test this!
    {
        bool isSprinting = false;
        bool isjumping = false;
        bool isDoubleJump = false;
        bool isInAir = false;
        bool isGlideing = false;
    }

    // what abilities does Cinny have compared too Sonic?

    private void Start()
    {
        rb = GetComponent<RigidBody>();
    }

    public groundMovement()
    {

    }

    private void EnterCollsion(Collsion collsion)
    {

    }
    
    public void FixedUpdate()
    {
        
    }
}
