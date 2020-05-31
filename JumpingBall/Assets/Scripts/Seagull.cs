using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagull : MonoBehaviour
{

    private Vector3 seagullPosition;
    private bool fliesRight;
    private Vector3 dropPoint;
    private float remainingTimeToDrop;
    private float timeToDrop;
    private float seagullSpeed;

    public Rigidbody seagullDroppings;

    private void Start()
    {
        seagullPosition = transform.position;
        fliesRight = true;
        remainingTimeToDrop = 0.75f;
        timeToDrop = remainingTimeToDrop;
        seagullSpeed = 6.5f;
    }

    private void Update()
    {
        SeagullFly();
        SeagullStartDroppings();
    }

    private void SeagullFly()
    {
        if (transform.position.x >= 21.5f)
        {
            fliesRight = false;
        }
        if (transform.position.x <= 5.5f)
        {
            fliesRight = true;
        }

        if (fliesRight)
        {
            seagullPosition += transform.right * Time.deltaTime * seagullSpeed;
            SeagullIsSwinging();
        }
        else
        {
            seagullPosition -= transform.right * Time.deltaTime * seagullSpeed;
            SeagullIsSwinging();
        }
    }

    private void SeagullIsSwinging()
    {
        transform.position = seagullPosition + transform.up * Mathf.Sin(Time.time * 2.0f) * 1.5f;
    }

    private void SeagullStartDroppings()
    {
        dropPoint = transform.GetChild(0).position;
        timeToDrop -= Time.deltaTime;
        if (timeToDrop <= 0.0f)
        {
            timeToDrop = remainingTimeToDrop;
            Instantiate(seagullDroppings, dropPoint, transform.rotation);
        }
    }

}
