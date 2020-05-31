using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleMovingVerticalGround : MonoBehaviour
{

    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.parent = null;
        }
    }

}
