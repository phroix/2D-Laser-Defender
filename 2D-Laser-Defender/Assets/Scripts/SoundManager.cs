using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    bool pressedSound = false;
    static SoundManager instance;
    AudioPlayer audioPlayer;
    void Awake()
    {
        audioPlayer = FindObjectOfType<AudioPlayer>();
    }

    public void ToggleSound()
    {
        pressedSound = !pressedSound;
        if (!pressedSound)
        {
            audioPlayer.MuteAudio();
        }
        else if (pressedSound)
        {
            audioPlayer.UnmuteAudio();
        }
    }


}
