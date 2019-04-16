using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStart : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;
    private bool isBGM = true;
    float i=2.4f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        isBGM=true;
    }

    // Update is called once per frame
    void Update()
    {
        i -= Time.deltaTime;
        if (i <= 0&&isBGM)
        {
            audioSource.Play();
            isBGM = false;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            isBGM = true;
        }
    }
}
