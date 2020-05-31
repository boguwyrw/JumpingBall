using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullDroppings : MonoBehaviour
{

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("GameBoundary"))
        {
            Destroy(gameObject);
        }
    }

}
