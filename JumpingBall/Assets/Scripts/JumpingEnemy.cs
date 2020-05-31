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
        jumpingEnemyRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        isGrounded = true;
    }

    private void Update()
    {
        if (isGrounded)
        {
            jumpingEnemyRigidbody.AddForce(Vector3.up * 2.75f, ForceMode.Impulse);
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
