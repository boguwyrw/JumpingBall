using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHorizontalGround : MonoBehaviour
{

    private bool groundIsMovingRight;

    public GameObject player;

    private void Start()
    {
        groundIsMovingRight = true;
    }

    private void Update()
    {
        if (transform.position.x >= 44.0f)
        {
            groundIsMovingRight = false;
        }
        if (transform.position.x <= 39.0f)
        {
            groundIsMovingRight = true;
        }

        if (groundIsMovingRight)
        {
            transform.Translate(Vector3.right * 1.75f * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * 1.75f * Time.deltaTime);
        }
    }
}
