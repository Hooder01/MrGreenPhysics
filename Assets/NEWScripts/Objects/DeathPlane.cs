using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    
    private GameObject callPlayer; 
    

    void Start()
    {
        callPlayer = GameObject.Find("sonicController");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            callPlayer.transform.position = new Vector3(0 , 0 , 0);

            // should also reset Base speed!
        }
    }
}
