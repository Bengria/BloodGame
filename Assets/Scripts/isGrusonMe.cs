using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrusonMe : MonoBehaviour
{
    public GameObject door;
    public bool isopen = false;

    private Vector3 posdor;

    private void Start()
    {
        posdor = door.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gruz")
            isopen = true;

    }
    private void FixedUpdate()
    {
        if(!isopen) door.transform.position = posdor;
        if (isopen && door.transform.position.y < 6)
        {
            Vector3 pos = door.transform.position;
            pos.y += 0.1f;
            door.transform.position = pos;
        }
    }
}
