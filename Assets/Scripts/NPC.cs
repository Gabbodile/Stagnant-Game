using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private TextAsset inkJson;
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
    public void Dialogue()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJson);
        InputManager.GetInstance().GetInteractPressed();
    }
}
