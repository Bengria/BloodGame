using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruzMovement : MonoBehaviour
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
        gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
        isMouseDown = true;
    }
    private void OnMouseUp()
    {
        gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        isMouseDown = false;
    }
}
