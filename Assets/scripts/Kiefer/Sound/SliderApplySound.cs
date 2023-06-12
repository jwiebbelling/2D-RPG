using UnityEngine;
using UnityEngine.UI;
using System;

public class SliderApplySound : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] bool SFX, Master, Music;
    [SerializeField] Text text;

    public AudioData data;

    void Awake()
    {
        if (SFX && !Master && !Music)
        {
            slider.value = data.SFXVolume;
        }
        else if (!SFX && Master && !Music)
        {
            slider.value = data.masterVolume;
        }
        else if (!SFX && !Master && Music)
        {
            slider.value = data.musicVolume;
        }
        else
        {
            Debug.LogError("need to pick SFX, Master or Music");
        }
    }
    void Update()
    {
        EditTXTValue((int)Mathf.Round(slider.value * 100));

        if (SFX && !Master && !Music)
        {
            data.SFXVolume = slider.value;
        }
        else if (!SFX && Master && !Music)
        {
            data.masterVolume = slider.value;
        }
        else if (!SFX && !Master && Music)
        {
            data.musicVolume = slider.value;
        }
    }
    void EditTXTValue(int value)
    {
        text.text = value.ToString() + " %";
    }
}