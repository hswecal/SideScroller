using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject Player;
    Vector3 currentPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPos.x = Player.transform.position.x;
        currentPos.y = Player.transform.position.y;
        currentPos.z = -10;
        transform.position = currentPos;
    }
}
