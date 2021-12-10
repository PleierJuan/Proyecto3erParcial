using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesoroCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;

            FindObjectOfType<Recolector>().AllTesorosCollected();

            Destroy(gameObject,0.5f);
        
        }
    
    
    
    }
        
    
}
