using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageClip;
    [SerializeField][Range(0f, 1f)] float damageVolume = 1f;

    [Header("Music")]
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayShootingClip()
    {
        PlayClip(shootingClip, shootingVolume);
    }
    public void PlayDamageClip()
    {
        PlayClip(damageClip, damageVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 camerPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, camerPos, volume);
        }
    }

    public void MuteAudio()
    {
        audioSource.volume = 0;
        shootingVolume = 0;
        damageVolume = 0;
    }

    public void UnmuteAudio()
    {
        audioSource.volume = .1f;
        shootingVolume = .1f;
        damageVolume = .1f;
    }
}
