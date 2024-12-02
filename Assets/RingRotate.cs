using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotate : MonoBehaviour
{
    private float onY = 1f;
    public GameObject RingSelf;

    void fixedRotation()
    {
        RingSelf.transform.Rotate(0, onY, 0, Space.World);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fixedRotation();
    }
}
