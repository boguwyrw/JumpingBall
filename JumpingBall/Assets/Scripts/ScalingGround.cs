using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingGround : MonoBehaviour
{

    private float minGroundScale;
    private float maxGroundScale;
    private float groundScale;
    private bool magnifyingScale;
    private float scalingSpeed;

    private void Start()
    {
        minGroundScale = 1.0f;
        maxGroundScale = 12.0f;
        groundScale = minGroundScale;
        transform.localScale = new Vector3(groundScale, 1.0f, 1.0f);
        magnifyingScale = true;
        scalingSpeed = 3.0f;
    }

    private void Update()
    {
        if (groundScale >= maxGroundScale)
        {
            magnifyingScale = false;
        }
        if (groundScale <= minGroundScale)
        {
            magnifyingScale = true;
        }

        if (magnifyingScale)
        {
            groundScale = groundScale + Time.deltaTime * scalingSpeed;
        }
        else
        {
            groundScale = groundScale - Time.deltaTime * scalingSpeed;
        }

        transform.localScale = new Vector3(groundScale, 1.0f, 1.0f);
    }
}
