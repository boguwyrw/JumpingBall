using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    private Vector3 bulletStartPosition;
    private float cannonBulletSpeed;
    private float remainingTimeToShot;
    private float timeToShot;

    public Rigidbody cannonBullet;

    private void Start()
    {
        cannonBulletSpeed = 700.0f;
        remainingTimeToShot = 2.5f;
        timeToShot = remainingTimeToShot;
    }

    private void Update()
    {
        CannonShot();
    }

    private void CannonShot()
    {
        bulletStartPosition = transform.GetChild(2).position;
        timeToShot -= Time.deltaTime;
        Rigidbody cannonBulletClone;
        if (timeToShot <= 0.0f)
        {
            timeToShot = remainingTimeToShot;
            cannonBulletClone = Instantiate(cannonBullet, bulletStartPosition, transform.rotation);
            cannonBulletClone.velocity = transform.TransformDirection(Vector3.left * cannonBulletSpeed * Time.deltaTime);
        }
    }

}
