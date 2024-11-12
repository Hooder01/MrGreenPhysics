using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBallProp : MonoBehaviour
{
    // Best not to touch this UNLESS you want to mess around with the speed of the rotation
    // (which in this case is just being used as an animation)

    public GameObject JumpBallSelf;
    private float onZAngle = 50f;

    void Start()
    {

    }

    void FixedUpdate()
    {

        JumpBallSelf.transform.Rotate(0f, 0f, onZAngle * Time.deltaTime, Space.World);
    }
    
}
