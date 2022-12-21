using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytankscript : MonoBehaviour
{
    //triangel fiendens skrip f�r r�relser och attack - max
    float stopwatch = 0f;
    public GameObject bulletPrefab;
    Vector3 force = new Vector3(-1, 0);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "playerAttack")
        {
            Destroy(gameObject); //d�r om den blir attackerad - max
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += Time.deltaTime; //timer f�r att skjuta
        if(stopwatch >= 5)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); //skjuter
            bullet.GetComponent<Rigidbody2D>().AddForce(force * 500); //ger kraft till kulan
            stopwatch = 0;
        }
    }
}
