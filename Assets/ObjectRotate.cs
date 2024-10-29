using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public float rotationSpeed;
    private RigidBody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<>(RigidBody); // why can't this be found!?
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
