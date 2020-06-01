using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{

    private bool directionRight;
    private float enemyDistance;
    private float enemyStartPosition;
    private float enemyEndPosition;
    private float enemySpeed;
    private float remainingTimeToChangeSpeed;
    private float timeToChangeSpeed;

    private void Start()
    {
        directionRight = true;
        enemyDistance = 11.0f;
        enemyStartPosition = transform.position.x;
        enemyEndPosition = enemyStartPosition + enemyDistance;
        enemySpeed = 0.0f;
        remainingTimeToChangeSpeed = 1.0f;
        timeToChangeSpeed = remainingTimeToChangeSpeed;
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

        EnemyChangeSpeed();

        if (directionRight)
        {
            transform.Translate(Vector3.right * enemySpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * enemySpeed * Time.deltaTime);
        }
    }

    private void EnemyChangeSpeed()
    {
        timeToChangeSpeed -= Time.deltaTime;
        if (timeToChangeSpeed <= 0.0f)
        {
            timeToChangeSpeed = remainingTimeToChangeSpeed;
            enemySpeed = Random.Range(1.25f, 3.16f);
        }
    }

}
