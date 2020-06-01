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
    private float playerJumpForce;
    private bool isGrounded;
    private Vector3 currentCheckpointPosition;
    private bool playerFinishedGame;
    private Finish finish;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;
        playerSlowSpeed = 1.0f;
        playerNormalSpeed = 2.0f;
        playerFastSpeed = 4.0f;
        playerSpeed = playerNormalSpeed;
        playerJumpForce = 6.8f;
        isGrounded = false;
        currentCheckpointPosition = new Vector3(-0.5f, 0.5f, 0.0f);
        playerFinishedGame = false;
        finish = FindObjectOfType<Finish>();
    }

    private void Update()
    {
        playerFinishedGame = finish.GetPlayerFinished();
        if (playerFinishedGame)
        {
            playerSpeed -= Time.deltaTime * 2;
            if (playerSpeed <= 0.0f)
            {
                playerSpeed = 0.0f;
            }
        }
        transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        
        //TestingButtons();
    }

    private void TestingButtons()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRigidbody.AddForce(Vector3.up * playerJumpForce, ForceMode.Impulse);
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
        /*
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            playerSpeed = 0;
        }
        */
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            currentCheckpointPosition = other.transform.GetChild(2).position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("RotatingEnemy"))
        { 
            
        }
    }

    public Vector3 GetCurrentCheckpointPosition()
    {
        return currentCheckpointPosition;
    }

    // UI Buttons
    public void JumpButton()
    {
        if (isGrounded)
        {
            playerRigidbody.AddForce(Vector3.up * playerJumpForce, ForceMode.Impulse);
        }
    }

    public void PlayerSlowSpeed()
    {
        playerSpeed = playerSlowSpeed;
    }

    public void PlayerNormalSpeed()
    {
        playerSpeed = playerNormalSpeed;
    }

    public void PlayerFastSpeed()
    {
        playerSpeed = playerFastSpeed;
    }

}
