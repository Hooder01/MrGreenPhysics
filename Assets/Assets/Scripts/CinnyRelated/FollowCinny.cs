using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCinny : MonoBehaviour
{
    public Transform player;
    public int camX = 0;
    public int camY = 0;
    public int camZ = 0;
    // find the default before sending out!

    void FixedUpdate()
    {
        transform.position = player.transform.position + new Vector3(0 , camY , camZ);
    }
}
