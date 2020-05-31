using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public Material checkedFlag;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.GetChild(1).GetComponent<MeshRenderer>().material.color = checkedFlag.color;
        }
    }

}
