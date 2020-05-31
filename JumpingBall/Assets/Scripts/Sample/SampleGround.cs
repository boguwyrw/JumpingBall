using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGround : MonoBehaviour
{

    private List<Rigidbody> sampleGroundsRigidbody = new List<Rigidbody>();
    private List<Vector3> sampleGroundsPositions = new List<Vector3>();
    private List<Quaternion> sampleGroundsRotations = new List<Quaternion>();
    private float fallingTime;

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

        foreach (GameObject sampleGroundPosition in sampleGroundList)
        {
            sampleGroundsPositions.Add(sampleGroundPosition.transform.position);
        }

        foreach (GameObject sampleGroundRotation in sampleGroundList)
        {
            sampleGroundsRotations.Add(sampleGroundRotation.transform.rotation);
        }

        fallingTime = 0.25f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            for (int i = 0; i < sampleGroundList.Count; i++)
            {
                fallingTime = fallingTime - Time.deltaTime;
                if (fallingTime <= 0.0f)
                {
                    fallingTime = 0.2f;
                    sampleGroundsRigidbody[i].constraints = RigidbodyConstraints.None;
                    sampleGroundsRigidbody[i].useGravity = true;
                }
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            for (int i = 0; i < sampleGroundsPositions.Count; i++)
            {
                sampleGroundList[i].transform.position = sampleGroundsPositions[i];
                sampleGroundList[i].transform.rotation = sampleGroundsRotations[i];
                sampleGroundsRigidbody[i].constraints = RigidbodyConstraints.FreezeAll;
                sampleGroundsRigidbody[i].useGravity = false;
            }
        }
    }

}
