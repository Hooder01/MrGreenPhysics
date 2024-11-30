using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoundsNEW : MonoBehaviour
{
    private GameObject playerObject;

    void Start()
    {
        playerObject = GameObject.Find("PlayerTEMP");
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.playerObject.CompareTag("Player"))
        {
            Debug.Log("Touched!");
        }
    }
}
