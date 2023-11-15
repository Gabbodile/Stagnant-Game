using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : GameBehaviour
{
    public AudioClip showerNoise;
    private void OnMouseDown()
    {
        if (_TIME.currentTime >= 3 || _LOOP.hasShowered)
            return;

        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        _LOOP.hasShowered = true;
    }
}
