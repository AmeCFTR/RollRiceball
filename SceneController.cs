using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    enum State
    {
        Ready,
        Play
    }
    // Start is called before the first frame update
    State state;
    public Text StartText;
    //public GameObject StartText2;
    public Text StartText3;
    public Text DistanceMeterText;
    public static bool isGameReady=true;

    void Start()
    {
        Ready();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        switch (state)
        {
            case State.Ready:
                if (Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.W)){
                    GameStart();
                }
                break;

            case State.Play:
                break;
        }
    }

     void Ready()
    {
        state = State.Ready;
        isGameReady = true;
        StartText.gameObject.SetActive(true);
       // StartText2.SetActive(true);
        StartText3.gameObject.SetActive(true);
        DistanceMeterText.gameObject.SetActive(false);
    }

     void GameStart()
    {
        state = State.Play;
        isGameReady = false;
        StartText.gameObject.SetActive(false);
       // StartText2.SetActive(false);
        StartText3.gameObject.SetActive(false);
        DistanceMeterText.gameObject.SetActive(true);
    }
}
