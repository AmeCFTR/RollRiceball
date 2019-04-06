using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoTitleOption : MonoBehaviour
{
    public Slider BGMSlider;
    public Slider SESlider;
    public static float CheckBGM=-13;
    public static float CheckSE=5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            CheckBGM = BGMSlider.value; //設定したBGMの音量値を保存
            CheckSE = SESlider.value; //設定したSEの音量値を保存
            SceneManager.LoadScene("Title");
        }
    }

    /*public void ButtonClicked()
    {
        SceneManager.LoadScene("Title");
        CheckBGM = BGMSlider.value; //設定したBGMの音量値を保存
        Debug.Log(CheckBGM);
        CheckSE = SESlider.value; //設定したSEの音量値を保存
    }*/
}
