using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    public AudioSource audio;
    public void play_sound()
    {
        audio.Play();
    }
}
