using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    float setSpeed = 10f;

    void FixedUpdate()
    {
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); // this can be used to spin any object on the Y Axis
    }
}
