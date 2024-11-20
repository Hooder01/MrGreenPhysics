using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBounds : MonoBehaviour
{

    private GameObject callPlayer; 
    private GameObject CheckPoint1;
    bool hasPassedCheckPoint;
    void Start()
    {
        callPlayer = GameObject.Find("playerSonic"); 
    }

    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("call for reaspawn!"); // is this printing?
            callPlayer.transform.position = new Vector3(0, 1, 0);
        }
        
    }

    
}
