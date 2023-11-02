using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : GameBehaviour
{
    /// <summary>
    /// This script will hold each NPC's indivitual inkJSON file and will trigger dialouge with them when they are clicked on
    /// </summary>

    [Header("Ink JSON")]
    [SerializeField] public TextAsset inkJSON;
    public bool disabled;


    private void OnMouseDown()
    {
        if (!_DM.dialogueIsPlaying && !disabled)
        {
            _DM.EnterDialogueMode(inkJSON);
        }
    }
}
