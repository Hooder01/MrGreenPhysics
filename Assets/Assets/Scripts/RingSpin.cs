using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpin : MonoBehaviour
{
    GameObject Ring; 
    AudioSource soundEffect;


    void Start()
    {
        Ring = GameObject.Find("RingPrefab");
        soundEffect = GetComponent<AudioSource>();
    }

    void defaultStance()
    {
        float setSpeed = 45f; // (only edit this!)
        transform.Rotate(0f, setSpeed * Time.deltaTime, 0f, Space.Self); 
    }

    void OnCollisionEnter(Collision collision)
    {
        soundEffect.Play();
    }

    void FixedUpdate()
    {
        defaultStance();
    }
}
