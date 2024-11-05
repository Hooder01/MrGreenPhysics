using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicControl : MonoBehaviour
{
    
    public GameObject callPlayer;   
    public GameObject DeathPlaneCall;
    bool hasPlayerDied;

    void Start()
    {
        hasPlayerDied = false;
    }

    
    void Update()
    {
        if(callPlayer == DeathPlaneCall)
        {
            Debug.Log("Stop playing this!");
        }
    }
}
