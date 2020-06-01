using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingEnemy : MonoBehaviour
{

    private Rigidbody jumpingEnemyRigidbody;
    private bool isGrounded;

    private void Start()
    {
        jumpingEnemyRigidbody = GetComponent<Rigidbody>();
        jumpingEnemyRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;
        isGrounded = true;
    }

    private void Update()
    {
        if (isGrounded)
        {
            float jumpForce = Random.Range(1.75f, 3.25f);
            jumpingEnemyRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}
