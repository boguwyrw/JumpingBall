using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoundary : MonoBehaviour
{
    
    private Vector3 playerPosition;
    private Player player;
    private bool playerRestartingPosition;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        playerRestartingPosition = false;
    }

    private void Update()
    {
        playerPosition = player.GetCurrentCheckpointPosition();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerRestartingPosition = true;
            collision.transform.position = playerPosition;
        }
        else
        {
            playerRestartingPosition = false;
        }
    }
    /*
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerRestartingPosition = false;
        }
    }
    */
    public bool GetPlayerRestartingPosition()
    {
        return playerRestartingPosition;
    }

}
