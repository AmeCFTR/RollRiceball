using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Invincible : MonoBehaviour
{
    public float waitTime=1.5f;
    public bool isDissappear;
    public AudioClip audioClip;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        if (isDissappear)
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = audioClip;
        }
    }

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
            fadeOut();
            }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            isDissappear = true;
        }
    }

    private void fadeOut()
    {
        if (isDissappear)
        {
            audioSource.Play();
            isDissappear = false;
        }

        iTween.FadeTo(gameObject, iTween.Hash(
                "alpha", 0,
                  "time", 1.5f,
              "oncomplete", "Destroy",
              "oncompletetarget", gameObject
                ));

    }
}

