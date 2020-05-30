using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGround : MonoBehaviour
{

    private List<Rigidbody> sampleGroundsRigidbody = new List<Rigidbody>();

    public List<GameObject> sampleGroundList = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < sampleGroundList.Count; i++)
        {
            sampleGroundsRigidbody.Add(gameObject.transform.GetChild(i).GetComponent<Rigidbody>());
        }

        foreach (Rigidbody sampleRigidbody in sampleGroundsRigidbody)
        {
            sampleRigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

}
