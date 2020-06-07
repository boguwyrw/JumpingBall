using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{

    private Rigidbody samplePlayerRigidbody;
    private AudioSource audioSource;
    private bool playSound;
    private int clipNumber;
    public AudioClip[] audioClips;

    private void Start()
    {
        samplePlayerRigidbody = GetComponent<Rigidbody>();
        samplePlayerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        audioSource = GetComponent<AudioSource>();
        playSound = false;
        clipNumber = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            playSound = true;
            clipNumber++;
            if (clipNumber >= audioClips.Length)
            {
                clipNumber = 0;
            }
        }

        if (playSound)
        {
            audioSource.clip = audioClips[clipNumber];
            float clipLength = audioClips[clipNumber].length;
            clipLength = clipLength - Time.deltaTime;
            Debug.Log(clipLength.ToString());
            if (clipLength >= 0.0f)
            {
                //audioSource.PlayOneShot(audioSource.clip);
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }

            playSound = false;
        }
        

        //transform.Translate(Vector3.right * 4 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            samplePlayerRigidbody.AddForce(Vector3.up * 6.5f, ForceMode.Impulse);
        }
    }
}
