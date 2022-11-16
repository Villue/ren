using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public void Sound()
    {
        audioSource.enabled = !audioSource.enabled;
    }
}
