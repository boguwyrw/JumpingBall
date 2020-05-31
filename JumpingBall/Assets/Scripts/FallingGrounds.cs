using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGrounds : MonoBehaviour
{

    private List<Rigidbody> fallingGroundsRigidbody = new List<Rigidbody>();
    private List<Vector3> fallingGroundsPositions = new List<Vector3>();
    private List<Quaternion> fallingGroundsRotations = new List<Quaternion>();
    private bool playerRestartedPosition;
    private GameBoundary gameBoundary;

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

        foreach (GameObject groundPosition in groundsList)
        {
            fallingGroundsPositions.Add(groundPosition.transform.position);
        }

        foreach (GameObject groundRotation in groundsList)
        {
            fallingGroundsRotations.Add(groundRotation.transform.rotation);
        }

        playerRestartedPosition = false;
        gameBoundary = FindObjectOfType<GameBoundary>();
    }

    private void Update()
    {
        playerRestartedPosition = gameBoundary.GetPlayerRestartingPosition();

        if (playerRestartedPosition)
        {
            for (int i = 0; i < fallingGroundsPositions.Count; i++)
            {
                groundsList[i].transform.position = fallingGroundsPositions[i];
                groundsList[i].transform.rotation = fallingGroundsRotations[i];
                fallingGroundsRigidbody[i].constraints = RigidbodyConstraints.FreezeAll;
                fallingGroundsRigidbody[i].useGravity = false;
            }
        }
    }

}
