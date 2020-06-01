using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    private List<Transform> lettersList = new List<Transform>();
    private bool playerFinished;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            lettersList.Add(transform.GetChild(i));
        }

        foreach (Transform letter in lettersList)
        {
            letter.gameObject.SetActive(false);
        }

        playerFinished = false;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (Transform letter in lettersList)
            {
                letter.gameObject.SetActive(true);
                playerFinished = true;
            }
        }
    }

    public bool GetPlayerFinished()
    {
        return playerFinished;
    }

}
