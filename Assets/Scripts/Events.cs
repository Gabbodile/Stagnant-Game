using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Events : MonoBehaviour
{
    [SerializeField] int toasterKey = 0;

    public GameObject kitchenBackground;
    public GameObject bedroomBackground;
    public GameObject bathroomBackground;
    public GameObject bathroomDoorBackground;

    public TextMeshProUGUI display;

    bool bathroom = false;
    bool bathroomDoor = false;
    bool bedroom = false;
    bool kitchen = false;
    bool bathroomOpen = false;

    public float textResetTime = 1f;

    public void Start()
    {
        kitchenBackground.SetActive(true);
        kitchen = true;
        bedroomBackground.SetActive(false);
        bathroomBackground.SetActive(false);
        bathroomDoorBackground.SetActive(false);
    }
    public void Update()
    {
        if (toasterKey >= 3)
        {
            bathroomOpen = true;
        }
    }
    public void SceneChanger()
    {
        if(kitchen == true)
        {
            kitchen = false;
            bathroomDoor = true;
            kitchenBackground.SetActive(false);
            bathroomDoorBackground.SetActive(true);
            Debug.Log("Bathroom Door");
        }
        else if (bedroom == true)
        {
            bedroom = false;
            kitchen = true;
            bedroomBackground.SetActive(false);
            kitchenBackground.SetActive(true);
            Debug.Log("Kitchen");
        }
        else if (bathroomDoor == true)
        {
            bathroomDoor = false;
            bedroom = true;
            bathroomDoorBackground.SetActive (false);
            bedroomBackground.SetActive(true);
            Debug.Log("Bedroom");
        }
        else if (bathroom == true)
        {
            bathroom = false;
            bathroomDoor = true;
            bathroomBackground.SetActive(false);
            bathroomDoorBackground.SetActive(true);
            Debug.Log("Bathroom Door 2");
        }
    }

    public void DoorOpen()
    {
        if (bathroomOpen == true)
        {
            bathroom = true;
            bathroomDoor = false;
            bathroomBackground.SetActive(true);
            bathroomDoorBackground.SetActive(false);
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
    }

    public IEnumerator resetText()
    {
        yield return new WaitForSeconds(textResetTime);
        display.text = "";
        StopCoroutine(resetText());
    }

}
