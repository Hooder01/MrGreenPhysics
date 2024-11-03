using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    float setSpeed = 45f;
    int ringCount;
    public GameObject Ring; // 1!
     
    private AudioSource audioSource; // sound1
    public AudioClip RingPickUp; //sound2

    void Start()
    {
        Ring = GameObject.Find("default"); // 2!
        audioSource = GetComponent<AudioSource>(); //sound3
       
    }

    void OnCollisionEnter(Collision collision)
    {
        audioSource.clip = RingPickUp;
        audioSource.Play();

        Debug.Log("Ring Gone!");
        Destroy(Ring); // 3!
        
        
    }


    void FixedUpdate()
    {
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); // this can be used to spin any object on the Y Axis
    }
}
