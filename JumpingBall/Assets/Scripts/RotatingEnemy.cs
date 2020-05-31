using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingEnemy : MonoBehaviour
{

    private bool directionRight;
    private float enemyDistance;
    private float enemyStartPosition;
    private float enemyEndPosition;

    private void Start()
    {
        directionRight = true;
        enemyDistance = 7.0f;
        enemyStartPosition = transform.position.x;
        enemyEndPosition = enemyStartPosition + enemyDistance;
    }

    private void Update()
    {
        if (transform.position.x >= enemyEndPosition)
        {
            directionRight = false;
        }
        if (transform.position.x <= enemyStartPosition)
        {
            directionRight = true;
        }

        if (directionRight)
        {
            transform.Translate(Vector3.right * 2.5f * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * 2.5f * Time.deltaTime);
        }
    }
}
