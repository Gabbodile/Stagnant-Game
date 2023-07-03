using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Sprite Portait;
    public string dialogueText;
    public UI uiManager;
    public int energyValue = 1;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit That NPC");
    }
    public void Dialogue()
    {
        uiManager.DialogueActivate();
        uiManager.DialogueBox.text = dialogueText;
        uiManager.PortraitDisplay.sprite = Portait;
        Debug.Log("Start Dialogue");
        //energytracker.energy = energytraker.energy - energyValue
    }
}
