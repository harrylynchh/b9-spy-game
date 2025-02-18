using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    //public Animator anim;
    public Rigidbody2D rb;
    public float jumpForce = 20f;
    public Transform feet;
    public bool canJump = false;
    public int jumpTimes = 0;
    public bool isAlive = true;
    //public AudioSource JumpSFX;

    void Start()
    {
        //anim = gameObject.GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if ((Input.GetButtonDown("Jump")) && (canJump) && (isAlive == true))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (jumpTimes < 2)
        {
            jumpTimes += 1;
            rb.velocity = Vector2.up * jumpForce;
        }
        else
        {
            canJump = false;
        }
        // anim.SetTrigger("Jump");
        // JumpSFX.Play();

        //Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        //rb.velocity = movement;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            jumpTimes = 0;
            canJump = true;
        }
    }
}