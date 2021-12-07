using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public float velocidad = 0.5f;
    private float waitTime;
    public float startWaitTime = 2;
    private int i = 0;
    private Vector2 posAct;
    public Transform[] moveSpots;


    void Start()
    {
        waitTime = startWaitTime;
    }

    void Update()
    {
        StartCoroutine(CheckEnemyMoving());

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, velocidad * Time.deltaTime);

        if (Vector2.Distance(transform.position,moveSpots[i].transform.position)<0.1f)
        {
            if (waitTime <= 0)
            {
                if (moveSpots[i] != moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }

                else
                {

                    i = 0;
                }
                waitTime = startWaitTime;

            }
            else 
            
           {
                waitTime -= Time.deltaTime; 
            }
        }

    }


    IEnumerator CheckEnemyMoving() {

        posAct = transform.position;
        yield return new WaitForSeconds(0.5f);



            if (transform.position.x > posAct.x)
        {
            spriteRenderer.flipX = false;

        }

        else if (transform.position.x< posAct.x) {
            spriteRenderer.flipX = true;
        }
    }
}
