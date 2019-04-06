using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seaweed : MonoBehaviour
{
    public GameObject GoalText;
    public bool canMove=true;
    private void OnCollisionEnter(Collision hit)
    {  
        if (hit.gameObject.CompareTag("Player"))
        {
            GoalText.gameObject.SetActive(true);
            canMove = false;
            Invoke("MoveResultScene", 3);
        }
    }
    
    private void MoveResultScene()
    {
        SceneManager.LoadScene("Result");
    }
}
