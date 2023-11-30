using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTime : MonoBehaviour
{
    public GameObject text;
   
    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        text.GetComponent<TimeUI>().x = 10;
    }
}
