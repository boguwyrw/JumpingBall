using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBullet : MonoBehaviour
{

    private Rigidbody cannonBulletRigidbody;

    void Start()
    {
        cannonBulletRigidbody = GetComponent<Rigidbody>();
        cannonBulletRigidbody.useGravity = false;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CannonBulletBoundary"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameBoundary") || collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }

}
