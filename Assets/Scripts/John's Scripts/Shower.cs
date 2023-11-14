using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : GameBehaviour
{
    public AudioClip showerNoise;
    private void OnMouseDown()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        _LOOP.hasShowered = true;
    }
}
