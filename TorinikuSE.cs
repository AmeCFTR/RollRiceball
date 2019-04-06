using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorinikuSE : MonoBehaviour
{
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
        }
    }
}
