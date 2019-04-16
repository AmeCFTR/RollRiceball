using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seaweed : MonoBehaviour
{
    public GameObject GoalText;
    public bool canMove=true;
    private bool isSEStart=true;
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        GimmickUI.Getcheck=1;
    }

    private void OnCollisionEnter(Collision hit)
    {  
        if (hit.gameObject.CompareTag("Player"))
        {
            GoalText.gameObject.SetActive(true);
            if (isSEStart)
            {
                audioSource.Play();
                isSEStart = false;
            }
            canMove = false;
            Invoke("MoveResultScene", 3);
        }
    }
    
    private void MoveResultScene()
    {
        isSEStart = true;
        canMove = true;
        SceneManager.LoadScene("Result");
    }
}
