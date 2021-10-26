using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPosition : MonoBehaviour
{

    Slider volumeSlider;

    void Start()
    {
        volumeSlider = GetComponent<Slider>();
        volumeSlider.value = TitleManager.masterVolume;
    }

   
}
