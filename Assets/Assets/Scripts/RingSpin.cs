using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    float setSpeed = 45f; // (only edit this!)
    
    public GameObject Ring; 

    

    void Start()
    {
        Ring = GameObject.Find("default"); 
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(Ring);        
    }


    void FixedUpdate()
    {
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); 
    }
}
