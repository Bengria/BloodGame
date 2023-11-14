using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDinamic : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocity;
    public bool jump;
    public bool isGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        velocity.x = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump")) jump = true;
    }

    private void FixedUpdate()
    {
        velocity.y = rb.velocity.y;
        if (jump) if (isGround)
            {
                velocity.y += 14;
            }
        if (jump) jump = false;

        rb.velocity = new Vector2(velocity.x * 5, velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") isGround = true;

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") isGround = false;

    }
}


