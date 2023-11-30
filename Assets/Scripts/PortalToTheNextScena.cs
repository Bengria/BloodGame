using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalToTheNextScena : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;

    public Vector3 plPos;
    public Vector3 camPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            player.transform.position = plPos;
            cam.transform.position = camPos;
        }
    }
}
