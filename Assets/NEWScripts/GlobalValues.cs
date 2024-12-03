using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalValues : MonoBehaviour
{
    //
    [Header("On_Ground_Control")]
    public float baseSpeed;
    public float accelerationSpeed;
    public float decelerationSpeed;
    public float topSpeed;
    //

    [Header("In_Air_Control")]
    public bool playerInAir;
    public float jumpForce;
    //
    
}
