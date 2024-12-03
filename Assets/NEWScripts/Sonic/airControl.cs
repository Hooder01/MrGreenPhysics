using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airControl : MonoBehaviour
{
    public GameObject callingJumpBall;
    public GlobalValues script;
    private Rigidbody rb;

    void Start()
    {
        callingJumpBall.SetActive(false);
        script.playerInAir = false;
        rb = GetComponent<Rigidbody>();
    }

    void inAirControl()
    {
        script.jumpForce = 6.1f;

        if(Input.GetKeyDown("space"))
        {
            script.playerInAir = true;
            rb.AddForce(transform.up * script.jumpForce, ForceMode.Impulse);
            callingJumpBall.SetActive(true);
        }
        /*else
        {
            callingJumpBall.SetActive(false);
        }*/
    }



    void Update()
    {
        inAirControl();
    }
}
