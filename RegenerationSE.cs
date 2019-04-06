using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegenerationSE : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            audioSource.Play();
        }
    }

   /* public void ButtonClicked()
    { 
            audioSource.Play();
    }*/
}
