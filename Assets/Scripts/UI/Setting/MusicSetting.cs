using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSetting : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField]private GlobalSetting globalSetting;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume", 0.8f);
    }
}
