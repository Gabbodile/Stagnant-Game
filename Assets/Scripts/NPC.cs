using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class NPC : MonoBehaviour
{

    [SerializeField] private TextAsset inkJson;
    public void Dialogue()
    {
        
        Inky.GetInstance().EnterDialogueMode(inkJson);
        //DialogueManager.GetInstance().EnterDialogueMode(inkJson);
       

    }
}
