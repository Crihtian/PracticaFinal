using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios;

    private AudioSource manageAudio;

    private void Awake()
    {
        manageAudio = GetComponent<AudioSource>();
    }

    public void AudioChoose (int audio, float volumen)
    {
        manageAudio.PlayOneShot(audios[audio], volumen);
    }
}
