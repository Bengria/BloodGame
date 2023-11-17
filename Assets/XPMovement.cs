using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPMovement : MonoBehaviour
{
    public bool isMouseDown = false;
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
        isMouseDown = true;
    }
    private void OnMouseUp()
    {
        isMouseDown=false;
    }
}
