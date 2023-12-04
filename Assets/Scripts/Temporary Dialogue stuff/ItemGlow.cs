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

    [Header("Loop Check")]
    public bool availibility = false;
    public int loopAvailable = 0;

    [Header("Sprites")]
    private SpriteRenderer spriteRender;
    public Sprite unselected;
    public Sprite selected;
    public Sprite available;

    [Header("Dialogue Box")]
    public GameObject dialogueBox;

    public bool donttalking;
    private int startingLayer;
    
    

    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
        startingLayer = gameObject.layer;
        
    }

    private void Update()
    {
        if (_LOOP.loop >= loopAvailable)
        {
            availibility = true;
        }

        //If dialogue active then it will make sure you dont click on random things
        if (dialogueBox.activeInHierarchy == true)
        {
            this.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
        }
        else if (dialogueBox.activeInHierarchy == false)
        {
            this.gameObject.layer = startingLayer;
        }
    }

    public void OnMouseOver()
    {
        if (availibility == false)
            spriteRender.sprite = available;
        else
            spriteRender.sprite = selected;
    }

    public void OnMouseExit()
    {
        spriteRender.sprite = unselected;
    }
}
