using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{

    private float rotationSpeed = 120.0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0.0f, rotationSpeed * Time.deltaTime, 0.0f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
