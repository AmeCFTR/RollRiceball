using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoCredit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoCreditScene", 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Credit");
        }
    }

    /*public void ButtonClicked()
    {
        SceneManager.LoadScene("Credit");
    }*/

    private void GoCreditScene()
    {
        SceneManager.LoadScene("Credit");
    }
}
