using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Sprite Portait;
    public string[] dialogueText;
    public int dialogueSelect;
    public UI uiManager;
    public CheckList CL;
    public int energyValue = 1;
    public string[] EventCheck;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit That NPC");
    }
    public void Dialogue()
    {
        for (int i = 0; i < CL.structArray.Length; i++) 
        {
            for (int j = 0; j < EventCheck.Length; j++)
            {
                if (CL.structArray[i].Event == EventCheck[j] && CL.structArray[i].Check == true)
                {
                    dialogueSelect = dialogueSelect + 1;
                }
            }
        }
        uiManager.DialogueActivate();
        uiManager.DialogueBox.text = dialogueText[dialogueSelect];
        uiManager.PortraitDisplay.sprite = Portait;
        Debug.Log("Start Dialogue");
        //energytracker.energy = energytraker.energy - energyValue
    }
}
