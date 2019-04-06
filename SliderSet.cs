using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSet : MonoBehaviour
{
    public Slider BGMSlider;
    public Slider SESlider;
    
    // Start is called before the first frame update
    void Start()
    {
        BGMSlider.value = GoTitleOption.CheckBGM;
        SESlider.value = GoTitleOption.CheckSE;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
