using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughingSounds : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip[] _clips;

    public void Play()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.Stop();
            _audioSource.clip = _clips[Random.Range(0, _clips.Length)];
            _audioSource.Play();
        }
    }
}
