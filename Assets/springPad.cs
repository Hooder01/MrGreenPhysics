using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springPad : MonoBehaviour
{
    
    private GameObject callPlayer;
    bool hasPlayerTouched;

    void Start()
    {
        callPlayer = GameObject.Find("playerSonic");
        hasPlayerTouched = false;
    }

    
    void OnCollisionEnter(Collision collision)
    {
        hasPlayerTouched = true;

        if(hasPlayerTouched == true)
        {
           Vector3 callPlayer = new Vector3(0, 5 ,0);

           if(callPlayer != Vector3)
           {
                Debug.Log("This is not being called!");
           }
        }
    }

     void FixedUpdate()
    {
        
    }
}
