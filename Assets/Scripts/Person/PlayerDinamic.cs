using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDinamic : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    public bool jump = false;
    public bool isGround;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !jump)
        {
            animator.SetBool("IsJumping", true);
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jump = true;

        }
    }
    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        if (moveX != 0 && !jump)
        {
            Vector3 rotate = transform.eulerAngles;
            if (moveX > 0) rotate.y = 0;
            if (moveX < 0) rotate.y = 180;
            transform.rotation = Quaternion.Euler(rotate);
            animator.SetBool("IsMoving", true);
        }
        if(!jump && moveX == 0 ) animator.SetBool("IsMoving", false);
        // Прыжок
        //if (Input.GetButtonDown("Jump") && !jump)
        //{
        //    animator.SetBool("IsJumping", true);
        //    rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        //    jump = true;
            
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверка, когда персонаж касается земли
        if (collision.gameObject.CompareTag("Ground"))
        {
            jump = false;
            animator.SetBool("IsJumping", false);

        }
    }
}


