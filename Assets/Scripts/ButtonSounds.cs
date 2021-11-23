using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource soundSource;
    public AudioClip soundClick;

    public void ClickSound()
    {
        soundSource.PlayOneShot(soundClick);
    }
}
