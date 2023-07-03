using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text DialogueBox;
    public Image PortraitDisplay;
    public GameObject panel;
    public Button closePanel;
    public void Start()
    {
        panel.SetActive(false);
    }
    public void DialogueActivate()
    {
        panel.SetActive(true);
    }
    public void closePanelFuncion()
    {
        panel.SetActive(false);
    }
}
