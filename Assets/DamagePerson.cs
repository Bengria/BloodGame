using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePerson : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<XpController>().playerXP -= 10;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<XpController>().playerXP -= 10;
    }

}
