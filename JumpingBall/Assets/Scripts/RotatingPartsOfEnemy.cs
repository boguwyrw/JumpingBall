using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPartsOfEnemy : MonoBehaviour
{

    private float enemyRotatingSpeed;

    void Start()
    {
        enemyRotatingSpeed = 350f;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, enemyRotatingSpeed * Time.deltaTime));
    }
}
