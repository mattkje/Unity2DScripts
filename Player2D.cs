using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 5f;
    public float walkSpeed = 3f;

    private bool isGrounded;

    void FixedUpdate()
    {
        // Check if the player is grounded (you need to implement this)
        isGrounded = true;/* Implement your grounded check here */;

        // Horizontal movement using GetAxis
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);

        // Jumping only when grounded
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Crouching logic (add your crouch code here)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // Implement crouch behavior
        }
    }
}