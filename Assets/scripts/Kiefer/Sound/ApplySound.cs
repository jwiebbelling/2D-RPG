using UnityEngine;

public class ApplySound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] bool Music, SFX;
    public AudioData data;
    private float volume;
    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = gameObject.GetComponent<AudioSource>();
        }
    }
    void Update()
    {
        EditVolume();
    }
    void EditVolume()
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