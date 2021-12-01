using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update zal de inpute in komen.
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }
    }
    
    // FixedUpdate zal de movement in komen.
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
