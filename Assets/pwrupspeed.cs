using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pwrupspeed : MonoBehaviour
{ // casper gjorde s� att den r�r sig upp och ner och max l�nkade ihop speed med spelaren
    Vector3 upp�t = new Vector3();
    Vector3 ner�t = new Vector3();
    bool r�rSigUpp�t = true;
    PlayerMovement pm;
    GameObject player;
    BoxCollider2D BC2D;
    
  
    // Start is called before the first frame update
    void Start()
    {
        upp�t.y = transform.position.y + 0.5f;
        ner�t.y = 0;
        upp�t.x = transform.position.x;
        ner�t.x = transform.position.x;
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
        if (r�rSigUpp�t == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, upp�t, 1 * Time.deltaTime);
            if (transform.position == upp�t)
            {
                r�rSigUpp�t = false;
            }
        }

        if (r�rSigUpp�t == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, ner�t, 1 * Time.deltaTime);
            {
                if(transform.position == ner�t)
                {
                    r�rSigUpp�t = true;
                }
            }
        }

    }
}
