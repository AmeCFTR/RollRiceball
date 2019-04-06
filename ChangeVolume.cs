using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public Slider BGMVolumeSlider;
    public Slider SEVolumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && ChooseOption.canRegenerationBGM) 
        {
            BGMVolumeSlider.value -= 0.6f;
        }

        else if (Input.GetKey(KeyCode.RightArrow) && ChooseOption.canRegenerationBGM) {
            BGMVolumeSlider.value += 0.6f;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && ChooseOption.canRegenerationSE) 
        {
            SEVolumeSlider.value -= 0.8f;
        }

        else if (Input.GetKey(KeyCode.RightArrow) && ChooseOption.canRegenerationSE) {
            SEVolumeSlider.value += 0.8f;
        }


    }
}
