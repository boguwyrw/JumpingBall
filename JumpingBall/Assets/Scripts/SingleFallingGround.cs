using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFallingGround : MonoBehaviour
{

    private Rigidbody singleGroundRigidbody;
    private float remainingTimeToFall;
    private float timeToFalling;

    private void Start()
    {
        singleGroundRigidbody = GetComponent<Rigidbody>();
        remainingTimeToFall = 0.1f;
        timeToFalling = remainingTimeToFall;
    }

    private void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timeToFalling = timeToFalling - Time.deltaTime;
            if (timeToFalling <= 0.0f)
            {
                timeToFalling = remainingTimeToFall;
                singleGroundRigidbody.constraints = RigidbodyConstraints.None;
                singleGroundRigidbody.useGravity = true;
            }
        }
    }

}
