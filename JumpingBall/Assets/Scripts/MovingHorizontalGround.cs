using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHorizontalGround : MonoBehaviour
{

    private bool groundIsMovingRight;
    private float groundSpeed;
    private float groundMovingDistance;
    private float groundStartPosition;
    private float groundEndPosition;

    public GameObject player;

    private void Start()
    {
        groundIsMovingRight = true;
        groundSpeed = 2.5f;
        groundMovingDistance = 7.0f;
        groundStartPosition = transform.position.x;
        groundEndPosition = groundStartPosition + groundMovingDistance;
    }

    private void FixedUpdate()
    {
        if (transform.position.x >= groundEndPosition)
        {
            groundIsMovingRight = false;
        }
        if (transform.position.x <= groundStartPosition)
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
