using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultCall : MonoBehaviour
{
    public Text TotalScore;
    public Text TotalRice;
    public Text TotalChicken;
    public Text TotalSalmon;
    public Text RiceBonusText;
    public Text DistanceBonusText;

    private float DistanceBonus;
    public static float TotalScorePoint=0;

    // Start is called before the first frame update
    void Start()
    {
        DistanceBonus = DistanceBonusCatch.DisBonus();

        TotalScorePoint = 0;
        TotalScorePoint = GameManager.resultScore + Item.RiceBonus + DistanceBonus;
        TotalScore.text = "TotalScore : "+TotalScorePoint.ToString("f0")+"点";
        RiceBonusText.text = "米粒ボーナス!   : +" + Item.RiceBonus+"点";
        DistanceBonusText.text = "距離差ボーナス! : +" + DistanceBonus + "点";
        TotalRice.text = "集めた米粒 : " + Item.RiceConuter+"粒";
        TotalChicken.text = "集めた鶏肉 : " + Toriniku.ChickenCounter + "切れ";
        TotalSalmon.text = "集めた鮭   : " + Salmon.SalmonCounter + "枚";

        Item.RiceConuter = 0;
        Item.RiceBonus = 0;
        Toriniku.ChickenCounter = 0;
        Salmon.SalmonCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("HighScore") < TotalScorePoint)
        {
            PlayerPrefs.SetFloat("HighScore", TotalScorePoint);
        }
    }
}
