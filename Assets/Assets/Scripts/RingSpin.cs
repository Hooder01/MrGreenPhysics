using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    float setSpeed = 25f;
    int ringCount;

    public GameObject Ring; // 1!

    void Start()
    {
        Ring = GameObject.Find("default"); // 2!
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ring Gone!");
         Destroy(Ring); // 3!
        // play effect here!
    }


    void FixedUpdate()
    {
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); // this can be used to spin any object on the Y Axis
    }
}
