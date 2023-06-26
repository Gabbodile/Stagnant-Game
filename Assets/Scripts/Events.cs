using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Events : MonoBehaviour
{
    [SerializeField] int toasterKey = 0;

    public GameObject bathroomBackground;
    public GameObject bathroomDoorBackground;
    public GameObject[] scenes;
    public int currentScene = 0;

    public TextMeshProUGUI display;
    public Button PrevButton;
    public Button NextButton;
    public Button LeaveButton;
    public float textResetTime = 1f;

    public GameObject OldMan;

    bool bathroomOpen = false;
    bool InBathroom = false;

    public void Start()
    {
        scenes[0].SetActive(true);
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i].SetActive(false);
            if (scenes[0])
            {
                scenes[0].SetActive(true);
                continue;
            }
        }
            LeaveButton.gameObject.SetActive(false);
        
    }
    public void Update()
    {
        if (toasterKey >= 3)
        {
            bathroomOpen = true;
        }
        if (currentScene == scenes.Length - 1)
        {
            NextButton.interactable = false;
        }
        else
        {
            NextButton.interactable = true;
        }
        if (currentScene == 0)
        {
            PrevButton.interactable = false;
        }
        else if(InBathroom == false)
        {
            PrevButton.interactable = true;
        }
    }
    public void SceneChanger()
    {
        InBathroom = false;
        bathroomBackground.SetActive(false);
        bathroomDoorBackground.SetActive(true);
        LeaveButton.gameObject.SetActive(false);
        NextButton.interactable = false;
        PrevButton.interactable = true;
        
    }

    public void NextScene()
    {
        
        scenes[currentScene].SetActive(false);
        scenes[currentScene + 1].SetActive(true);
        currentScene = currentScene + 1;
    }
    public void PreviousScene()
    {
        
        scenes[currentScene].SetActive(false);
        scenes[currentScene - 1].SetActive(true);
        currentScene = currentScene - 1;
    }
    public void DoorOpen()
    {
        if (bathroomOpen == true)
        {
            InBathroom = true;
            bathroomBackground.SetActive(true);
            bathroomDoorBackground.SetActive(false);
            LeaveButton.gameObject.SetActive(true);
            NextButton.interactable = false;
            PrevButton.interactable = false;
        }
        else
        {
            display.text = "The Door Is Locked";
            StartCoroutine(resetText());
        }
    }

    public void ToasterClicked()
    {
        toasterKey = toasterKey + 1;
        display.text = "*Rattle*";
        StartCoroutine(resetText());
    }

    public void OldManTalk()
    {
        display.text = "That Damn Toaster is Messing with the Locks Again, can you try giving it a couple of Wacks for me? I need my Medicine from the Bathroom";
        textResetTime = 5f;
        StartCoroutine(resetText());
        textResetTime = 1f;
    }

    public void FoundMeds()
    {
        display.text = "congrats You found Your Schizophrenia Meds now would you kindly take them";
        OldMan.SetActive(false);
    }

    public IEnumerator resetText()
    {
        yield return new WaitForSeconds(textResetTime);
        display.text = "";
        StopCoroutine(resetText());
    }

}
