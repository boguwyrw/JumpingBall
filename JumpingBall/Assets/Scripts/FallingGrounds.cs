using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGrounds : MonoBehaviour
{

    private List<Rigidbody> fallingGroundsRigidbody = new List<Rigidbody>();

    public List<GameObject> groundsList = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < groundsList.Count; i++)
        {
            fallingGroundsRigidbody.Add(gameObject.transform.GetChild(i).GetComponent<Rigidbody>());
        }
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (Rigidbody groundRigidbody in fallingGroundsRigidbody)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                groundRigidbody.useGravity = true;
            }
        }
        
    }
}
