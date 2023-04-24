using UnityEngine;
using UnityEngine.UI;

public class LoadSaveSound : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string MasterVolumePref = "MasterVolumePref";
    private static readonly string SFXVolumePref = "SFXVolumePref";
    private static readonly string MusicVolumePref = "MusicVolumePref";

    private int firstPlayInt;

    public AudioData data;

    void Awake()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        LoadSoundSettings();
    }
    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }
    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(MasterVolumePref, data.masterVolume);
        PlayerPrefs.SetFloat(SFXVolumePref, data.SFXVolume);
        PlayerPrefs.SetFloat(MusicVolumePref, data.musicVolume);
    }
    void LoadSoundSettings()
    {
        if (firstPlayInt == 0)
        {
            PlayerPrefs.SetInt(FirstPlay, +1);
            PlayerPrefs.SetFloat(MasterVolumePref, data.masterVolume);
            PlayerPrefs.SetFloat(SFXVolumePref, data.SFXVolume);
            PlayerPrefs.SetFloat(MusicVolumePref, data.musicVolume);
        }
        else
        {
            data.masterVolume = PlayerPrefs.GetFloat(MasterVolumePref);
            data.SFXVolume = PlayerPrefs.GetFloat(SFXVolumePref);
            data.musicVolume = PlayerPrefs.GetFloat(MusicVolumePref);
        }
    }
}
