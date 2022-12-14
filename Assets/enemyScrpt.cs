using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScrpt : MonoBehaviour
{
    //kod f�r fiender, r�relse - max

    bool movingLeft = true;
    Vector3 targetPosLeft = new Vector3();
    Vector3 targetPosRight = new Vector3();
  

    void Start()
    {
        targetPosLeft.x = transform.position.x - 5;
        targetPosRight.x = transform.position.x + 5;
        

    }


    void Update()
    {
        if (movingLeft == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosLeft, 3 * Time.deltaTime); //fiende r�r sig �t v�nster - max
            if (transform.position == targetPosLeft)
            {
                movingLeft = false;
            }
        }

        if (movingLeft == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosRight, 3 * Time.deltaTime); //fiende r�r sig �t h�ger - max
            if (transform.position == targetPosRight)
            {
                movingLeft = true;
            }
        }
    }
}
