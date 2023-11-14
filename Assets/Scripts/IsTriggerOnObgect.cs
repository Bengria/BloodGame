using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsTriggerOnObgect : MonoBehaviour
{
    
    private GameObject bag;
    public GameObject panel;
    public GameObject portal;
    public GameObject text,boxText;

    private void Update()
    {
        if (bag != null && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(bag);
            panel.SetActive(true);
            portal.SetActive(true);
            text.SetActive(false);
            boxText.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Bag")
        {
            text.SetActive(true);
            boxText.SetActive(true);
            bag = collision.gameObject;
        }
    }

   

    private void OnTriggerExit2D(Collider2D collision)
    {
        bag = null;
        text.SetActive(false);
        boxText.SetActive(false);
    }

}
