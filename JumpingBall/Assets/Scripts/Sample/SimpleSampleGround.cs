using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSampleGround : MonoBehaviour
{

    private Rigidbody simpleRigidbody;
    private float fallingTime;
    private bool sampleGroundFalling;

    void Start()
    {
        simpleRigidbody = GetComponent<Rigidbody>();
        fallingTime = 0.17f;
        sampleGroundFalling = false;
    }

    void Update()
    {
        /*
        fallingTime = fallingTime - Time.deltaTime;
        
        if (fallingTime <= 0.0f)
        {
            fallingTime = 3.0f;
        }

        Debug.Log(fallingTime.ToString("F2"));
        */
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fallingTime = fallingTime - Time.deltaTime;
            if (fallingTime <= 0.0f)
            {
                fallingTime = 0.17f;
                simpleRigidbody.constraints = RigidbodyConstraints.None;
                simpleRigidbody.useGravity = true;
            } 
        }
    }

}
