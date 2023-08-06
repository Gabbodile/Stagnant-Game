using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    [SerializeField] private TextAsset inkJson;
    public void Dialogue()
    {
      if(Interact.GetInstance().GetInteractPressed())
        {
            Inky.GetInstance().EnterDialogueMode(inkJson);
        }
        
    }
}
