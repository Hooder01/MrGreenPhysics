using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    public float onY = 1;
    public float onZ = -4;

    public Transform camTarget;

    
    void FixedUpdate()
    {
        transform.position = camTarget.transform.position + new Vector3(0, onY, onZ);
    }
}
