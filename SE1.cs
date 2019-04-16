using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class SE1 : MonoBehaviour {
        //public AudioClip audioClip;
        //public AudioClip audioClip2;
        AudioSource audioSource;
        AudioSource audioSource2;
        AudioSource audioSource3;

        AudioSource[] audioSources;
        private bool isWater;

        void Start() {
            // audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
            // audioSource.clip = audioClip;

            audioSources = GetComponents<AudioSource>();
            audioSource = audioSources[0];
            audioSource2 = audioSources[1];
            audioSource3 = audioSources[2];

            isWater = true;
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
                audioSource3.PlayOneShot(audioSource3.clip);
            }
            else if (collision.gameObject.CompareTag("Floor"))
            {
                audioSource2.Stop();
                isWater = true;
            }

        }

        private void OnCollisionStay(Collision col)
        {
            if (col.gameObject.CompareTag("Water")&&isWater)
            {
                audioSource2.PlayOneShot(audioSource2.clip);
                isWater = false;
            }
            
           /* else if(col.gameObject.CompareTag("Floor"))
            {
                audioSource2.Stop();
            }*/
        }
    }
}