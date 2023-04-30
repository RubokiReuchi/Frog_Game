using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2f;
    public float jumpSpeed = 3f;
    public float dobleJumpSpeed = 3f;
    public bool dobleJump = false;
    private int jumpCount = 1; //Saltos en el aire
    public static bool attacking = false;
    Rigidbody2D rb2D;
    SpriteRenderer sr;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (CheckGround.isGrounded)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            }
            else if (dobleJump && jumpCount > 0) //DobleJump Unlocked
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, dobleJumpSpeed);
                jumpCount--;
            }
        }
        
        if (CheckGround.isGrounded == false)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Jump", true);
        }
        else if (CheckGround.isGrounded == true)
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Falling", false);
            jumpCount = 1;
        }

        if (rb2D.velocity.y < 0)
        {
            anim.SetBool("Falling", true);
        }
        else
        {
            anim.SetBool("Falling", false);
        }

        //Attack
        if (Input.GetKeyDown("e"))
        {
            attacking = true;
            anim.Play("Attack");
            Invoke("StopAttacking", 0.02f);
        }
    }

    void StopAttacking()
    {
        attacking = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            sr.flipX = false;
            anim.SetBool("Run", true);
        }
        else if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            sr.flipX = true;
            anim.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            anim.SetBool("Run", false);
        }
    }
}
