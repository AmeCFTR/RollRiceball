using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkerEqually : MonoBehaviour
{
    public float Interval = 1.0f;
    private float nextTime;
    private GameObject TargetText;
    public string BlinkText;
    // Start is called before the first frame update
    void Start()
    {
        TargetText = GameObject.Find(BlinkText);
        nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            float alpha = TargetText.GetComponent<CanvasRenderer>().GetAlpha();

            if (alpha == 1.0f)
            {
                TargetText.GetComponent<CanvasRenderer>().SetAlpha(0.01f);

            }

            else
            {
                TargetText.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }

            nextTime += Interval;
        }
    }
}
