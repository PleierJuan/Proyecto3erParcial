using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controldos : MonoBehaviour
{
    public float velocidad = 2f;
    public float saltar = 8f;
    Rigidbody2D rb2D;

    private Animator anim, ataq,sal,para;
    public SpriteRenderer Sprite;

    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplayer = 1f;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        ataq = GetComponentInChildren<Animator>();
        sal = GetComponentInChildren<Animator>();
        para = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()

    {
        //rb2D.velocity = new Vector2(velocidad, rb2D.velocity.y);
        //ataq.SetTrigger("Caminar");

        if (Input.GetKey("x"))
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            Sprite.flipX = false;
            para.SetTrigger("Parado");
        }

        else {
            rb2D.velocity = new Vector2(velocidad, rb2D.velocity.y);
            ataq.SetTrigger("Caminar");
        }
        if (Input.GetKey("z"))
        {
          
            ataq.SetTrigger("Ataque");
        }
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {

            rb2D.velocity = new Vector2(rb2D.velocity.x, saltar);
            sal.SetTrigger("Saltar");
        }
        if (betterJump) {
            if (rb2D.velocity.y < 0) {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }
            if ( rb2D.velocity.y>0 && !Input.GetKey("space")) 
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplayer) * Time.deltaTime;
            }
        
        }



    }
}
