using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pwrupspeed : MonoBehaviour
{ // casper gjorde så att den rör sig upp och ner och max länkade ihop speed med spelaren
    Vector3 uppåt = new Vector3();
    Vector3 neråt = new Vector3();
    bool rörSigUppåt = true;
    PlayerMovement pm;
    GameObject player;
    BoxCollider2D BC2D;
    
  
    // Start is called before the first frame update
    void Start()
    {
        uppåt.y = transform.position.y + 0.5f;
        neråt.y = 0;
        uppåt.x = transform.position.x;
        neråt.x = transform.position.x;
        player = FindObjectOfType<PlayerMovement>().gameObject;
        pm = player.GetComponent<PlayerMovement>();
        BC2D = GetComponent<BoxCollider2D>();
    }

    IEnumerator SpeedPower()
    {
        yield return new WaitForSeconds(10);
        pm.speed = 5;
        Destroy(gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pm.speed *= 2;
            StartCoroutine(SpeedPower());
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (rörSigUppåt == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, uppåt, 1 * Time.deltaTime);
            if (transform.position == uppåt)
            {
                rörSigUppåt = false;
            }
        }

        if (rörSigUppåt == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, neråt, 1 * Time.deltaTime);
            {
                if(transform.position == neråt)
                {
                    rörSigUppåt = true;
                }
            }
        }

    }
}
