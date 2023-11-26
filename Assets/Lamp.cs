using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject player;
    public GameObject lamp;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collision.GetComponent<XpController>())
            {
                
                StartCoroutine(SomeCoroutine(collision.gameObject));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collision.GetComponent<XpController>())
            {
                StartCoroutine(SomeCoroutine(collision.gameObject));
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (collision.GetComponent<XpController>())
            {

                StartCoroutine(SomeCoroutine(collision.gameObject));
            }
        }
    }

    private IEnumerator SomeCoroutine(GameObject player)
    {
        float xp = player.GetComponent<XpController>().playerXP;
        player.GetComponent<XpController>().playerXP = xp - 10;
        for (int i = 0; i < 10; i++)
        {
            if (lamp.GetComponent<Light>().intensity <= 5) 
            {
                lamp.GetComponent<Light>().intensity += 1;
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
