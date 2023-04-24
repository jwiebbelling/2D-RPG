using UnityEngine;
using UnityEngine.UI;

public class SliderApplySound : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject[] audioSource;
    [SerializeField] bool SFX, Master, Music;
    [SerializeField] int SFXNumber; //0 = music

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
    }

    void Update()
    {
        
        if (SFX && !Master && !Music)
        {
            data.SFXVolume = slider.value;
            EditSound();
        }
        else if (!SFX && Master && !Music)
        {
            data.masterVolume = slider.value;
        }
        else if (!SFX && !Master && Music)
        {
            data.musicVolume = slider.value;
            EditSound();
        }
        
    }
    void EditSound()
    {
        audioSource[SFXNumber].GetComponent<ApplySound>().EditVolume();
    }
}
