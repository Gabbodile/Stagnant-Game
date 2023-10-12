using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    //[SerializeField] private TextAsset inkFile;
    //public Collider2D collider2d;
    //public bool playOnStart;

    //[Header("Dialogue Box")]
    //public GameObject dialogueBox;

    //[Header("Name Box")]
    //public TMP_Text nameText;
    //public string namebox = "";

    //public bool donttalking;

    //private void Start()
    //{
    //    if (playOnStart == true)
    //    {
    //        Dialogue();
    //    }
    //}
    //private void FixedUpdate()
    //{
    //    //if (DialogueManager.GetInstance().dialogueIsPlaying)
    //    //{
    //    //    collider2d.enabled = false;
    //    //}
    //    //if (!DialogueManager.GetInstance().dialogueIsPlaying)
    //    //{
    //    //    collider2d.enabled = true;
    //    //}

    //    if (dialogueBox.activeInHierarchy == true)
    //    {
    //        this.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
    //    }
    //    else if (dialogueBox.activeInHierarchy == false)
    //    {
    //        this.gameObject.layer = LayerMask.NameToLayer("Props");
    //    }

    //}

    //private void OnMouseDown()
    //{
    //    if (donttalking == false)
    //    {
    //        dialogueBox.SetActive(true);
    //        Dialogue();
    //        //boxText = true;
    //    }
    //}
    //public void Dialogue()
    //{
    //    DialogueManager.GetInstance().EnterDialogueMode(inkFile);
    //    InputManager.GetInstance().GetInteractPressed();
    //}
}
