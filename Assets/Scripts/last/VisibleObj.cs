using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleObj : MonoBehaviour
{
    public GameObject obg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            obg.SetActive(true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
            obg.SetActive(false);
        
    }
}
