using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemGlow : MonoBehaviour
{
    public Renderer itemColour;
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public TMP_Text nameText;
    public string textbox = "";
    public string namebox = "";

    void Start()
    {
        itemColour = gameObject.GetComponent<Renderer>();
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
