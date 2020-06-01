using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingVerticalGrounds : MonoBehaviour
{

    private float verticalSlowSpeed;
    private float verticalNormalSpeed;
    private float verticalFastSpeed;
    private List<GameObject> movingVerticalGroundsList = new List<GameObject>();
    private List<bool> groundMovingUpList = new List<bool>();

    private void Start()
    {
        verticalSlowSpeed = 4.0f;
        verticalNormalSpeed = 6.0f;
        verticalFastSpeed = 8.0f;

        for (int i = 0; i < transform.childCount; i++)
        {
            movingVerticalGroundsList.Add(transform.GetChild(i).gameObject);
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            groundMovingUpList.Add(true);
        }
    }

    private void FixedUpdate()
    {
        GroundsMovingVertical();
    }

    private void GroundsMovingVertical()
    {
        for (int i = 0; i < movingVerticalGroundsList.Count; i++)
        {
            if (movingVerticalGroundsList[i].transform.localPosition.y >= 12)
            {
                groundMovingUpList[i] = false;
            }
            if (movingVerticalGroundsList[i].transform.localPosition.y <= -6)
            {
                groundMovingUpList[i] = true;
            }
        }

        for (int i = 0; i < movingVerticalGroundsList.Count; i++)
        {
            if (groundMovingUpList[i].Equals(true))
            {
                if (i == 0)
                {
                    transform.GetChild(0).Translate(Vector3.up * verticalSlowSpeed * Time.deltaTime);
                }
                if (i == 1)
                {
                    transform.GetChild(1).Translate(Vector3.up * verticalFastSpeed * Time.deltaTime);
                }
                if (i == 2)
                {
                    transform.GetChild(2).Translate(Vector3.up * verticalNormalSpeed * Time.deltaTime);
                } 
            }
            else
            {
                if (i == 0)
                    transform.GetChild(0).Translate(Vector3.down * verticalSlowSpeed * Time.deltaTime);

                if (i == 1)
                    transform.GetChild(1).Translate(Vector3.down * verticalFastSpeed * Time.deltaTime);

                if (i == 2)
                    transform.GetChild(2).Translate(Vector3.down * verticalNormalSpeed * Time.deltaTime);
            }
        }
    }

}
