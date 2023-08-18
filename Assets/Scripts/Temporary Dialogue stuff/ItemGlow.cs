using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemGlow : GameBehaviour<ItemGlow>
{

    /// <summary>
    /// This script allows people to hover over interactable items as well as change what the character thinks about each item when clicked.
    /// </summary>

    private SpriteRenderer spriteRender;
    public Sprite unselected;
    public Sprite selected;

    [Header("Dialogue Box")]
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public string textbox = "";
   
    [Header("Name Box")]
    public TMP_Text nameText;
    public string namebox = "";

    public bool donttalking;
    //bool boxText = false;

    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (dialogueBox.activeInHierarchy == true)
        {
            this.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
        }
        else if (dialogueBox.activeInHierarchy == false)
        {
            this.gameObject.layer = LayerMask.NameToLayer("Props");
        }
    }

    private void OnMouseOver()
    {
        spriteRender.sprite = selected;
    }

    private void OnMouseExit()
    {
        spriteRender.sprite = unselected;
    }

    private void OnMouseDown()
    {
        if (donttalking == false)
        {
            dialogueBox.SetActive(true);
            nameText.text = namebox;
            dialogueText.text = textbox;
            //boxText = true;
        }
    }
}
