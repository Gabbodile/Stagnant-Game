using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    /// <summary>
    /// This script will hold each NPC's indivitual inkJSON file and will trigger dialouge with them when they are clicked on
    /// </summary>

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;


    private void OnMouseDown()
    {
        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            // made it a coroutine to prevent dialogue skipping the first line
            StartCoroutine(StartDialogue());
        }
    }

    private IEnumerator StartDialogue()
    {
        yield return new WaitForSeconds(0.1f);

        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
