using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerRespawn>().PasarCheckPoint(transform.position.x, transform.position.y);

            
        }
    
    }
}
