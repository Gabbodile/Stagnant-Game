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

    [Header("Sprites")]
    private SpriteRenderer spriteRender;
    public Sprite unselected;
    public Sprite selected;
    public Sprite available;

    [Header("Dialogue Box")]
    public GameObject dialogueBox;

    public bool donttalking;
    private int startingLayer;
    
    public bool availibility = false;

    void Start()
    {
        spriteRender = gameObject.GetComponent<SpriteRenderer>();
        startingLayer = gameObject.layer;

    }

    private void Update()
    {
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
        if (availibility == false)
            spriteRender.sprite = selected;
        else
            spriteRender.sprite = available;
    }

    private void OnMouseExit()
    {
        spriteRender.sprite = unselected;
    }
}
