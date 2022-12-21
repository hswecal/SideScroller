using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwrupstrength : MonoBehaviour
{
    int strength = 5; // byt n�r vi har en strength best�md
    Vector3 upp�t = new Vector3();
    Vector3 ner�t = new Vector3();
    bool r�rSigUpp�t = true;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        strength *= 2;
    }
    void Start()
    {
        upp�t.y = transform.position.y + 0.5f;
        upp�t.x = transform.position.x;
        ner�t.y = 0;
        ner�t.x = transform.position.x;
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
                if (transform.position == ner�t)
                {
                    r�rSigUpp�t = true;
                }
            }
        }
    }
}
