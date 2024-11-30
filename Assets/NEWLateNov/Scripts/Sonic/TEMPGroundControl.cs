using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMPGroundControl : MonoBehaviour
{
    private Rigidbody rb;

    public GlobalObjectAccess script;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        script.inputX = Input.GetAxis("Horizontal");
        script.inputZ = Input.GetAxis("Vertical");

        script.velocity = new Vector3(script.inputX, 0, script.inputZ) * script.baseGroundSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + script.velocity);
    }
}
