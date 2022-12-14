using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    [SerializeField] public float jumpforce = 1f;
    public Rigidbody2D rb2d;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-2, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(2, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.AddForce(new Vector3(0, 1, 0) * jumpforce);
        }
    }
}
