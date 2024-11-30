using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    
    void Start()
    {
       
    }

    void defaultStance()
    {
        float setSpeed = 45f; // (only edit this!)
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); 
    }

    void FixedUpdate()
    {
        defaultStance();
    }
}
