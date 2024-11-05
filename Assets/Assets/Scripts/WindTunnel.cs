using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTunnel : MonoBehaviour
{
    public GameObject WindGem;
    public GameObject callPlayer;

    bool playerHasGem = false;
    bool hasplayertouched = false; // for debug only!

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        hasplayertouched = true;
        if(hasplayertouched == true)
        {
            Debug.Log("Touched!");
        }

        callPlayer.transform.position = new Vector3(0, 1, 50);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
