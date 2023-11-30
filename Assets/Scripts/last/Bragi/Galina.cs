using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galina : MonoBehaviour
{
    public GameObject player;
    public GameObject portal;
    public GameObject text;
    private bool siiix;
    // Start is called before the first frame update
    void Start()
    {
        
        siiix = player.GetComponent<Inventory>().sixname;

    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(siiix == true)
        {
            gameObject.SetActive(false);
        }
        if (siiix == false)
        {
            portal.SetActive(true);
            text.SetActive(true);
        }
    }
}
