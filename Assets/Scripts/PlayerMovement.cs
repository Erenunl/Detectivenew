using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 3f;
    bool isWalking = false;
    public Animator walkAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (moveInput < 0)
        {
            FlipToRight();
        }
        if (moveInput > 0)
        {
            FlipToLeft();
        }

        if (moveInput != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
        walkAnim.SetBool("isWalking", isWalking);
    }

    void FlipToRight()
    {
        //facingRight = true;
        transform.localScale = new Vector3(-1, 1, 1);
    }

    void FlipToLeft()
    {
        //facingRight = false;
        transform.localScale = new Vector3(1, 1, 1);
    }

}
