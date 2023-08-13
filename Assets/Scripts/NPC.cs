using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [SerializeField] private TextAsset inkJson;
    public void Dialogue()
    {
      
            Inky.GetInstance().EnterDialogueMode(inkJson);
       // DialogueManager.GetInstance().EnterDialogueMode(inkJson);
       

    }
}
