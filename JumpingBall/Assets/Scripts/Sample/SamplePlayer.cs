using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{

    private Rigidbody samplePlayerRigidbody;

    private void Start()
    {
        samplePlayerRigidbody = GetComponent<Rigidbody>();
        samplePlayerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * 4 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            samplePlayerRigidbody.AddForce(Vector3.up * 6.5f, ForceMode.Impulse);
        }
    }
}
