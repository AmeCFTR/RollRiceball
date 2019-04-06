using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using UniRx;

public class Blinker : MonoBehaviour
{
    [SerializeField]
    private float angularFrequency = 5f;
    static readonly float DeltaTime = 0.0333f;
    private Text text;

    void Start()
    {
        float time = 0.0f;
        text = GetComponent<Text>();
        Observable.Interval(TimeSpan.FromSeconds(Time.deltaTime)).Subscribe(_ =>
        {
            time += angularFrequency * Time.deltaTime;
            var color = text.color;
            color.a = Mathf.Sin(time) * 0.5f + 0.65f;
            text.color = color;
        }).AddTo(this);
    }
}