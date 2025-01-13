using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if (audioSource != null)
            volumeSlider.value = audioSource.volume;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        if (audioSource != null)
            audioSource.volume = volume;
    }
}
