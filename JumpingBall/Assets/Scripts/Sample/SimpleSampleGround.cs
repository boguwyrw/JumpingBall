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
        if (Input.GetKeyDown(KeyCode.F))
        {
            fallingTime = fallingTime - Time.deltaTime;
            if (fallingTime <= 0.0f)
            {
                fallingTime = 0.17f;
                simpleRigidbody.constraints = RigidbodyConstraints.None;
                simpleRigidbody.useGravity = true;
            }
        }
        */
    }
    /*
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
    */
}
