using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDinamic : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool jump = false;
    public bool isGround;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // Перемещение персонажа по горизонтали
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        // Прыжок
        if (Input.GetButtonDown("Jump") && !jump)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jump = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверка, когда персонаж касается земли
        if (collision.gameObject.CompareTag("Ground"))
        {
            jump = false;
        }
    }
}


