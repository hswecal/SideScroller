using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pwrupspeed : MonoBehaviour
{
    int speed = 5;
    Vector3 upp�t = new Vector3();
    Vector3 ner�t = new Vector3();
    bool r�rSigUpp�t = true;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed *= 2; // Tror detta b�r funka bara f�r att h�ja spelarens r�relse fart. -casper
    }
    // Start is called before the first frame update
    void Start()
    {
        upp�t.y = transform.position.y + 0.5f;
        ner�t.y = 0;
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
