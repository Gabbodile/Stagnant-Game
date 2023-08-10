using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemGlow : GameBehaviour<ItemGlow>
{

    /// <summary>
    /// This script allows people to hover over interactable items as well as change what the character thinks about each item.
    /// </summary>
    
    public Renderer itemColour;
    
    [Header("Dialogue Box")]
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public string textbox = "";
   
    [Header("Name Box")]
    public TMP_Text nameText;
    public string namebox = "";

    [Header("Choices")]
    public GameObject choices;
    public bool choiceActive;

    void Start()
    {
        itemColour = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (choiceActive == true)
            choices.SetActive(true);

    }

    private void OnMouseOver()
    {
        itemColour.material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        itemColour.material.color = Color.white;
    }

    private void OnMouseDown()
    {
        dialogueBox.SetActive(true);
        nameText.text = namebox;
        dialogueText.text = textbox;
    }
}
