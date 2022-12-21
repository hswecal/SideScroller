using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeleteScript : MonoBehaviour
{
    float stopwatch = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatch += Time.deltaTime;
        if (stopwatch >= 10)
        {
            Destroy(gameObject);
        }
    }
}
