using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPMovement : MonoBehaviour
{
    public bool isMouseDown = false;
    public GameObject line;
    private void Start()
    {
        line.GetComponent<BoxCollider2D>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 cam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cam.z = 10;
        if (isMouseDown)
        {
            gameObject.transform.parent = null;
            gameObject.transform.position = cam;
        }
    }

    private void OnMouseDown()
    {
        line.GetComponent<BoxCollider2D>().enabled = false;
        isMouseDown = true;
    }
    private void OnMouseUp()
    {
        line.GetComponent<BoxCollider2D>().enabled = true;
        isMouseDown = false;
    }
}
