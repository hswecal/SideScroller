using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytankscript : MonoBehaviour
{
    float stopwatch = 0f;
    public GameObject bulletPrefab;
    Vector3 force = new Vector3(-1, 0);

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
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(force * 5);
            stopwatch = 0;
        }
    }
}
