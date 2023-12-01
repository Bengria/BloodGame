using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruzMovement : MonoBehaviour
{
    public bool isMouseDown = false;
    public GameObject player;
    public bool isWithBlood = false;
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
        float xp = player.GetComponent<XpController>().playerXP;
        if (!isWithBlood) 
        {
            isWithBlood = true;
            player.GetComponent<XpController>().playerXP = xp - 10; 
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            isMouseDown = true;
        }
    }
    private void OnMouseUp()
    {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        isMouseDown = false;
    }

    public void FirstStay()
    {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        gameObject.GetComponent<Rigidbody2D>().Sleep();
    }
}
