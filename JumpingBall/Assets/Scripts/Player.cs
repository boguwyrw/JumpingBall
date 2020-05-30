using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    private float playerSlowSpeed;
    private float playerNormalSpeed;
    private float playerFastSpeed;
    private float playerSpeed;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        playerSlowSpeed = 1.0f;
        playerNormalSpeed = 2.0f;
        playerFastSpeed = 4.0f;
        playerSpeed = playerNormalSpeed;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);

        TestingButtons();
    }

    private void TestingButtons()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * 6.5f, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerSpeed = playerSlowSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerSpeed = playerNormalSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerSpeed = playerFastSpeed;
        }
    }

}
