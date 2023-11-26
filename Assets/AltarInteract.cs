using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarInteract : MonoBehaviour
{
    public GameObject cam;
    public GameObject[] gruzes;
    public Vector3[] posGruzes;

    private void Start()
    {
        for (int i = 0; i < gruzes.Length; i++)
        {
            posGruzes[i] = gruzes[i].transform.position;
        }
    }

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
        yield return new WaitForSeconds(0.01f);
        float xp = player.GetComponent<XpController>().playerXP;
        player.GetComponent<XpController>().playerXP = 100;
        for (int i = 0; i < gruzes.Length; i++)
        {
            if (gruzes[i].GetComponent<GruzMovement>())
                gruzes[i].GetComponent<GruzMovement>().FirstStay();
            gruzes[i].transform.parent = cam.transform;
            gruzes[i].transform.position = posGruzes[i];

        }
    }

    
}
