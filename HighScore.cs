using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = "現在のハイスコア : " + PlayerPrefs.GetFloat("HighScore").ToString("f0") + "点";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
