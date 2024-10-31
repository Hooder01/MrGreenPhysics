using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSonic : MonoBehaviour
{
    public Transform player;
    private int camX = 0; // this will likely never be used so I have set to private!
    int camY = 1;
    int camZ = -8;
    // edit these values at ease

    // we will want some mouse control in the future!

    void FixedUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, camY, camZ);
    }
}
