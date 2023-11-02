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
    private int startingLayer;
<<<<<<< Updated upstream
=======

    public LoopAndChoices _LOOP;
    
>>>>>>> Stashed changes

    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
        startingLayer = gameObject.layer;
        
    }

    private void Update()
    {
<<<<<<< Updated upstream
=======
        //if (_LOOP.loop == loopAvailable)
        //{

        //}

        //If dialogue active then it will make sure you dont click on random things
>>>>>>> Stashed changes
        if (dialogueBox.activeInHierarchy == true)
        {
            this.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
        }
        else if (dialogueBox.activeInHierarchy == false)
        {
            this.gameObject.layer = startingLayer;
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
