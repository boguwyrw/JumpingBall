using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingVerticalGrounds : MonoBehaviour
{

    private float verticalSlowSpeed;
    private float verticalNormalSpeed;
    private float verticalFastSpeed;
    private List<GameObject> movingVerticalGroundsList = new List<GameObject>();
    private bool groundMovingUp;

    private void Start()
    {
        verticalSlowSpeed = 4.0f;
        verticalNormalSpeed = 6.0f;
        verticalFastSpeed = 8.0f;

        for (int i = 0; i < transform.childCount; i++)
        {
            movingVerticalGroundsList.Add(transform.GetChild(i).gameObject);
        }

        groundMovingUp = true;
    }

    private void FixedUpdate()
    {
        GroundsMovingVertical();
    }

    private void GroundsMovingVertical()
    {
        foreach (GameObject movingVerticalGround in movingVerticalGroundsList)
        {
            if (movingVerticalGround.transform.localPosition.y >= 12.0f)
            {
                groundMovingUp = false;
            }
            if (movingVerticalGround.transform.localPosition.y <= -6.0f)
            {
                groundMovingUp = true;
            }
        }

        if (groundMovingUp)
        {
            transform.GetChild(0).Translate(Vector3.up * verticalSlowSpeed * Time.deltaTime);
            transform.GetChild(1).Translate(Vector3.up * verticalFastSpeed * Time.deltaTime);
            transform.GetChild(2).Translate(Vector3.up * verticalNormalSpeed * Time.deltaTime);
        }
        else
        {
            transform.GetChild(0).Translate(Vector3.down * verticalSlowSpeed * Time.deltaTime);
            transform.GetChild(1).Translate(Vector3.down * verticalFastSpeed * Time.deltaTime);
            transform.GetChild(2).Translate(Vector3.down * verticalNormalSpeed * Time.deltaTime);
        }
    }

}
