using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    float setSpeed = 45f;
    int ringCount = 0;
    public GameObject Ring; // 1!

    //
    AudioSource SoundEffect;
    bool playsound;
    bool toggle;
    // RingSound1

    void Start()
    {
        Ring = GameObject.Find("default"); // 2!

        //
        SoundEffect = GetComponent<AudioSource>();
        playsound = false; // never to be used on start up!
        // RingSound2
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ring Gone!");
        ringCount++;
        playsound = true;

        if(playsound == true)
        {
            Debug.Log("Sound playing?");
            SoundEffect.Play(); // why isn't this working?
        }

        Destroy(Ring); 


        
    }


    void FixedUpdate()
    {
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); // this can be used to spin any object on the Y Axis
    }
}
