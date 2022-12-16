using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pwrupspeed : MonoBehaviour
{
    int speed = 5;
    Vector3 uppåt = new Vector3();
    Vector3 neråt = new Vector3();
    bool rörSigUppåt = true;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed *= 2; // Tror detta bör funka bara för att höja spelarens rörelse fart. -casper
    }
    // Start is called before the first frame update
    void Start()
    {
        uppåt.y = transform.position.y + 0.5f;
        neråt.y = 0;
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
