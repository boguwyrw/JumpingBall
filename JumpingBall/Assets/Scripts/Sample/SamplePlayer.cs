using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{

    private Rigidbody samplePlayerRigidbody;
    private AudioSource audioSource;
    private bool playSound;
    private int clipNumber;
    private int testNumber;
    public AudioClip[] audioClips;

    private void Start()
    {
        samplePlayerRigidbody = GetComponent<Rigidbody>();
        samplePlayerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        audioSource = GetComponent<AudioSource>();
        playSound = false;
        clipNumber = 0;
        testNumber = 5;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.N))
        {
            testNumber--;
        }

        if (testNumber == 0)
        {
            playSound = true;
            clipNumber = 2;
            if (clipNumber >= audioClips.Length)
            {
                clipNumber = 0;
            }
        }

        PlayGameSounds(clipNumber);
        /*
        if (playSound)
        {
            audioSource.clip = audioClips[clipNumber];
            audioSource.Play();
            playSound = false;
        }
        */

        //transform.Translate(Vector3.right * 4 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            samplePlayerRigidbody.AddForce(Vector3.up * 6.5f, ForceMode.Impulse);
        }
    }

    private void PlayGameSounds(int songNo)
    {
        if (playSound)
        {
            audioSource.clip = audioClips[songNo];
            audioSource.PlayOneShot(audioSource.clip);
            playSound = false;
        }
    }

}
