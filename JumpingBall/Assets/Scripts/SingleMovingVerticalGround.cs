using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleMovingVerticalGround : MonoBehaviour
{

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.parent = null;
        }
    }

}
