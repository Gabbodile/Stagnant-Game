using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnDialogue : MonoBehaviour
{
    public Collider2D collider2d;

    private void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            collider2d.enabled = false;
        }
        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            collider2d.enabled = true;
        }

    }
}
