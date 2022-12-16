using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScrpt : MonoBehaviour
{
    //kod f�r fiender, r�relse, d�d - max

    bool movingLeft = true;
    Vector3 targetPosLeft = new Vector3();
    Vector3 targetPosRight = new Vector3();
    float attackTimer = 0f;
    float stopwatch = 0f;
    Rigidbody2D rb2D;
    int jumpForce = 250;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); //d�r om den r�r en spelar - max
        }
    }

    void Start()
    {
        targetPosLeft.x = transform.position.x - 5;
        targetPosRight.x = transform.position.x + 5;
        attackTimer = Random.Range(3, 8);
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        stopwatch += Time.deltaTime;
        if (movingLeft == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosLeft, 1 * Time.deltaTime); //fiende r�r sig �t v�nster - max
            if (transform.position == targetPosLeft)
            {
                movingLeft = false;
            }
        }

        if (movingLeft == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosRight, 1 * Time.deltaTime); //fiende r�r sig �t h�ger - max
            if (transform.position == targetPosRight)
            {
                movingLeft = true;
            }
        }

        if(stopwatch >= attackTimer)
        {
            rb2D.AddForce(new Vector3(0, 1, 0) * jumpForce); //fiende hoppar efter en tid. random varje g�ng
            stopwatch = 0;
            attackTimer = Random.Range(3, 8);
        }

    }
}
