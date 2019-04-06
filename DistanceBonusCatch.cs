using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBonusCatch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int DisBonus()
    {
        float CatchDis = 0;
        CatchDis = 1000 - (Distance.DistanceDifference * 10); //距離ボーナスの計算(最大1000点)
        return (int)CatchDis;
    }

}
