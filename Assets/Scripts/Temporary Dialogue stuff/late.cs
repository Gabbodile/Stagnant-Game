using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class late : GameBehaviour
{
    bool hasSpoken;
    public bool isLate = false;
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

        //Temp
        if (!isDressed)
        {
            Debug.Log("Dressed");
            dialogueTrigger.inkJSON = inkJSON_main;
        }
        else
        {
            Debug.Log("Poor");
            dialogueTrigger.inkJSON = inkJSON_alt;
        }

        if (_LOOP.late)
        {
            isLate = true;
            Speak();
            _DM.EnterDialogueMode(dialogueTrigger.inkJSON);
        }


        

    }

    //private void Update()
    //{
    //    if (isLate == true)
    //    {
    //        Debug.Log("Boss speaking");
    //        Speak();
    //    }
    //}

    private void Speak()
    {
        if (isLate == true)
        {
            _DM.EnterDialogueMode(dialogueTrigger.inkJSON);
            Debug.Log("Boss speaking");
            hasSpoken = true;
        }
            
    }
}
