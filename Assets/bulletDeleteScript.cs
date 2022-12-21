using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeleteScript : MonoBehaviour
{
    public int attackDamage = 20;

    float stopwatch = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += Time.deltaTime;
        if (stopwatch >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
    }
}
