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

        foreach (Rigidbody groundRigidbody in fallingGroundsRigidbody)
        {
            groundRigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    private void Update()
    {
        
    }

}
