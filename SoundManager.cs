using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip soundClip; // Reference to the audio clip you imported
    public AudioSource beepSource;

    public void ButtonSound()
    {
        if (!beepSource.isPlaying)
        {
            beepSource.Play();
        }
    }
}
