using UnityEngine;

public class ApplySound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] bool Music, Master;
    public AudioData data;
    private float volume;
    void Start()
    {
        EditVolume();
    }
    public void EditVolume()
    {
        CalculateVolume();
        SetAudio();
    }
    void CalculateVolume()
    {
        if (Music)
        {
            volume = data.masterVolume * data.musicVolume;
        }
        else
        {
            volume = data.masterVolume * data.SFXVolume;
        } 
    }

    void SetAudio()
    {
        audioSource.volume = volume;       
    }
}