using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class late : GameBehaviour
{
    bool hasSpoken;
    public TextAsset inkJSON_main; //Temp
    public TextAsset inkJSON_alt; //Temp
    DialogueTrigger dialogueTrigger;
    public bool isDressed = false;

    private void Start()
    {
        hasSpoken = false;
        dialogueTrigger = GetComponent<DialogueTrigger>();

        if (_LOOP.dressed)
            isDressed = true;

        if (_LOOP.late)
            Speak();
 
        //Temp
        if (!isDressed)
        {
            dialogueTrigger.inkJSON = inkJSON_main;
        }
        else
        {
            dialogueTrigger.inkJSON = inkJSON_alt;
        }
    }

    private void Speak()
    {
        _DM.EnterDialogueMode(dialogueTrigger.inkJSON);
    }
}
