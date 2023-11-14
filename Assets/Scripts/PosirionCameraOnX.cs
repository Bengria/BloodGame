using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosirionCameraOnX : MonoBehaviour
{
    public GameObject player;
    public float minX;
    public int maxX;
    
    
    void Update()
    {
        Vector3 cameraPos = gameObject.transform.position;
        Vector3 p = player.transform.position;
        cameraPos.x = p.x;
        if (cameraPos.x > minX && cameraPos.x <= maxX) transform.position = cameraPos;



    }
}
