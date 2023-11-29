using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarInteract : MonoBehaviour
{
    public GameObject cam;
    public GameObject[] gruzes;
    public Vector3[] posGruzes;


    public GameObject xpLine;
    public GameObject ypLine;
    public Vector3 xpPosLine;
    public GameObject parentxpLine;

    private GameObject player;

    private bool isCol;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isCol)
        {
            StartCoroutine(SomeCoroutine(player.gameObject));
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerDinamic>())
        {
            isCol = true;
            player = collision.gameObject;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerDinamic>())
        {
            isCol = true;
            player = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerDinamic>())
        {
            isCol = false;
            player = collision.gameObject;
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
            { 
                gruzes[i].transform.parent = cam.transform;
                gruzes[i].GetComponent<GruzMovement>().FirstStay();
                gruzes[i].transform.localPosition = posGruzes[i];
            }
        }
        xpLine.transform.parent = parentxpLine.transform;
        xpLine.transform.localPosition =xpPosLine;
        ypLine.GetComponent<BoxCollider2D>().enabled = false;
    }

    
}
