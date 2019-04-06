using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class SE1 : MonoBehaviour {
        //public AudioClip audioClip;
        //public AudioClip audioClip2;
        AudioSource audioSource;
        AudioSource audioSource2;

        AudioSource[] audioSources;
        void Start() {
            // audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
            // audioSource.clip = audioClip;

            audioSources = GetComponents<AudioSource>();
            audioSource = audioSources[0];
            audioSource2 = audioSources[1];
        }

        // Update is called once per frame
        void Update() {

        }

        private void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.CompareTag("Rice")) {
                audioSource.PlayOneShot(audioSource.clip);
            }

            else if (collision.gameObject.CompareTag("Toriniku")||collision.gameObject.CompareTag("Salmon"))
            {
                audioSource2.PlayOneShot(audioSource2.clip);
            }
        }
    }
}