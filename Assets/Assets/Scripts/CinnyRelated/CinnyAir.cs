using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinnyAir : MonoBehaviour
{
    
    public GameObject objectSelf;
    public GameObject objectJumpBall; // (make these private later!)
    
    bool isjumping;
    bool isDoubleJump;
    bool isInAir;
    bool isGlideing;



    void Start()
    {
        objectSelf.SetActive(true);
        if(objectSelf == false)
        {
            Debug.Log("FailSafe Active!"); // (idk why I added this)
            Destroy(objectSelf);
        }

        objectJumpBall.SetActive(false);
        isInAir = false;
    }

    
    void onJump()
    {

    }



    void FixedUpdate()
    {
        
    }
}
