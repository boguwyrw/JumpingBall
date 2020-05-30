using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHorizontalGround : MonoBehaviour
{

    private bool groundIsMovingRight;
    private float groundSpeed;

    public GameObject player;

    private void Start()
    {
        groundIsMovingRight = true;
        groundSpeed = 2.5f;
    }

    private void Update()
    {
        if (transform.position.x >= 46.0f)
        {
            groundIsMovingRight = false;
        }
        if (transform.position.x <= 39.0f)
        {
            groundIsMovingRight = true;
        }

        if (groundIsMovingRight)
        {
            transform.Translate(Vector3.right * groundSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * groundSpeed * Time.deltaTime);
        }
    }
}
