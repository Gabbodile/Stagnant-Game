using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrictCoworker : GameBehaviour
{
    bool hasSpoken;
    public TextAsset inkJSON_main; //Temp
    public TextAsset inkJSON_alt; //Temp
    DialogueTrigger dialogueTrigger;
    public bool hasShowered = false;

    private void Start()
    {
        hasSpoken = false;
        dialogueTrigger = GetComponent<DialogueTrigger>();

        if (_LOOP.hasShowered)
            hasShowered = true;

        //Temp
        if (!hasShowered)
        {
            dialogueTrigger.inkJSON = inkJSON_main;
        }
        else
        {
            dialogueTrigger.inkJSON = inkJSON_alt;
        }

    }

    private void OnMouseDown()
    {
        hasSpoken = true;
    }

    public void CubicleTalk()
    {
        if (hasSpoken)
            return;

        _DM.EnterDialogueMode(dialogueTrigger.inkJSON);

        hasSpoken = true;
    }
}
