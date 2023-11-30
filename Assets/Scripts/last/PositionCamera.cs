using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCamera : MonoBehaviour
{

    public GameObject player;
    public float x;
    // Update is called once per frame
    void Update()
    {
        Vector3 p = player.transform.position;
        p.z = -10;
        p.y += x;
        transform.position = p;


    }
}
