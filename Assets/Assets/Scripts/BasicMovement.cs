using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class BasicMovement : MonoBehaviour
{
    public float BaseSpeed; // public base speed for sonic that is zero by default 

    private Rigidbody rb; // calls rigidbody from object and given new data name? 

    void Start() 
    {
        rb = GetComponent<Rigidbody>(); 
    }
    
    void FixedUpdate()
    {
        float moveAlongX = Input.GetAxis("Horizontal");
        float moveAlongZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveAlongX, 0, moveAlongZ) * BaseSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }
}
