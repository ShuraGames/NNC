using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSinlton : MonoBehaviour
{
    public static MusicSinlton musicSinlton;

    [SerializeField] private List<AudioClip> audioClips;

    private AudioSource audioSource;

    private void Awake() 
    {
        musicSinlton = this;    
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(int index)
    {
        audioSource.PlayOneShot(audioClips[index]);
    }
}
