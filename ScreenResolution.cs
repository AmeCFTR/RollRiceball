using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution: MonoBehaviour{

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Screen.SetResolution(1440, 810, false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
