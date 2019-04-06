using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegenerationBGM : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip audioClip;
    private AudioSource audioSource;
    private bool isMusicControll = true;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        isMusicControll = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)&&isMusicControll) {
            audioSource.Play();
            isMusicControll = false;
        } else if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.DownArrow)&&isMusicControll == false) {
            audioSource.Stop();
            isMusicControll = true;
        }
    }

  /*  public void ButtonClicked() {
        if (isMusicControll)
        {
            audioSource.Play();
            isMusicControll = false;
        }

        else if(isMusicControll==false)
        {
            audioSource.Stop();
            isMusicControll = true;
        }
    }*/
}
