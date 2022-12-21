using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwrupstrength : MonoBehaviour
{
    int strength = 5; // byt när vi har en strength bestämd
    Vector3 uppåt = new Vector3();
    Vector3 neråt = new Vector3();
    bool rörSigUppåt = true;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        strength *= 2;
    }
    void Start()
    {
        uppåt.y = transform.position.y + 0.5f;
        uppåt.x = transform.position.x;
        neråt.y = 0;
        neråt.x = transform.position.x;
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
                if (transform.position == neråt)
                {
                    rörSigUppåt = true;
                }
            }
        }
    }
}
