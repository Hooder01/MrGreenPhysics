using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windGem : MonoBehaviour
{
    
    bool hasGrabbedGem; // Grabbed1
    bool positionchanged; //AnimContext1

    private GameObject gemSelf; // Grabbed2

    
    

    void Start()
    {
        hasGrabbedGem = false; // always false on start //Grabbed3
        positionchanged = false; // AnimContext2
    }

    void OnCollisionEnter(Collision collision)
    {

        gemSelf = GameObject.Find("WindGemPrefab"); //Grabbed4

        hasGrabbedGem = true;

        if(hasGrabbedGem == true) //Grabbed5
        {
            positionchanged = true; // AnimContext3

            if(hasGrabbedGem == true && positionchanged == true) 
            {
                transform.position = transform.position + new Vector3(0, 0, 0); // I want the gem to go into the air for a short peroid of time before being destoryed
            }
            

            Destroy(gemSelf); // temp? //Grabbed6
        }
    }
}
