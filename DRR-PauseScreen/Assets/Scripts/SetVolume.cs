using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public void SetMusicLevel(float sliderValue)
    {
        mixer.SetFloat("volumeMusic", Mathf.Log10(sliderValue) * 20);
    }
    public void SetMasterLevel (float sliderValue)
    {
        mixer.SetFloat("volumeMaster", (Mathf.Log10(sliderValue) * 20));
    }
}
