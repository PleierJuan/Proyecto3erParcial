using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float velocidad=8f;
    public float saltar = 8f;
    Rigidbody2D rb2D;

    private Animator anim, ataq,sal;
    public SpriteRenderer Sprite;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        ataq = GetComponentInChildren<Animator>();
        sal = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(velocidad, rb2D.velocity.y);
            anim.SetTrigger("Caminar");
            Sprite.flipX = false;
        }
        else if (Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-velocidad, rb2D.velocity.y);
            anim.SetTrigger("Caminar");
            Sprite.flipX = true;
        }

        else {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
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


    }
}
