using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chooseMode : MonoBehaviour
{
    public GameObject ChooseGame;
    public GameObject ChooseOption;
    private bool isModeGame; 
    // Start is called before the first frame update
    void Start()
    {
        ChooseGame.SetActive(true);
        ChooseOption.SetActive(false);
        isModeGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChooseGame.SetActive(false);
            ChooseOption.SetActive(true);
            isModeGame = false;
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChooseGame.SetActive(true);
            ChooseOption.SetActive(false);
            isModeGame = true;
        }

        if (isModeGame&&Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Rule");
        }

        else if(isModeGame == false && Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("Option");
        }
    }
}
