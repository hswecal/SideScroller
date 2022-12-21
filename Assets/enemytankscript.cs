using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytankscript : MonoBehaviour
{
    float stopwatch = 0f;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += Time.deltaTime;
        if(stopwatch >= 5)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            bullet.rb2D.addForce
        }
    }
}
