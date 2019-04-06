using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoResult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Result");
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("ResultNormal");
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
