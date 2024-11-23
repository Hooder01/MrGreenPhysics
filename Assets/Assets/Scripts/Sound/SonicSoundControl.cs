using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicSoundControl : MonoBehaviour
{
    AudioSource callingJump;

    void Start()
    {
        callingJump = GetComponent<AudioSource>();
    }


    void JumpEffect()
    {
        if (Input.GetKeyDown("space"))
        {
            callingJump.Play();
        }
    }
    
    void FixedUpdate()
    {
        JumpEffect();
    }
}
