using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytankscript : MonoBehaviour
{
    //triangel fiendens skrip för rörelser och attack - max
    float stopwatch = 0f;
    public GameObject bulletPrefab;
    Vector3 force = new Vector3(-1, 0);

    public int attackDamage = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += Time.deltaTime; //timer för att skjuta
        if(stopwatch >= 5)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); //skjuter
            bullet.GetComponent<Rigidbody2D>().AddForce(force * 500); //ger kraft till kulan
            stopwatch = 0;
        }
    }
}
