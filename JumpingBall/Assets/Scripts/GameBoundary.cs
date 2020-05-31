using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoundary : MonoBehaviour
{
    
    private Vector3 playerPosition;
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        playerPosition = player.GetCurrentCheckpointPosition();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = playerPosition;
        }
    }
    
}
