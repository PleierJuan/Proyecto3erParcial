using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hongo : MonoBehaviour
    
{
    public float velocidad = 2f;
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = new Vector2(-velocidad, rb2D.velocity.y);
    }
}
