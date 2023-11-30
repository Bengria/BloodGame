using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    public bool isGruz = false;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Gruz")
        {
            isGruz = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gruz")
        {
            isGruz = false;
        }
    }
}
