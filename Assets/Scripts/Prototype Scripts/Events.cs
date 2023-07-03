using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Events : MonoBehaviour
{
    //simple int to act as a key
    [SerializeField] int toasterKey = 0;

    //Reffrence to the Bathroom "Scene"
    public GameObject bathroomBackground;
    //Array of all other Scenes
    public GameObject[] scenes;
    //Keeps track of current scene
    public int currentScene = 0;


    //Ui Elements
    public TextMeshProUGUI display;
    public Button PrevButton;
    public Button NextButton;
    public Button LeaveButton;
    public float textResetTime = 1f;

    //Dialogue Array
    public string[] dialogue;

    //Reffrences GameObject
    public GameObject OldMan;

    //Bathroom checks
    bool bathroomOpen = false;
    bool InBathroom = false;

    public void Start()
    {
        //Sets all but the first "scene" to deactivate
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i].SetActive(false);
            if (scenes[0])
            {
                scenes[0].SetActive(true);
                continue;
            }
        }

        //Hides button needed for later
            LeaveButton.gameObject.SetActive(false);
        
    }
    public void Update()
    {
        //checks if the door has been unlocked
        if (toasterKey >= 3)
        {
            bathroomOpen = true;
        }

        ButtonController();//checks where we are in the world and enabes/disables the button when the end is reached
    }
    public void SceneChanger()//Lets the Player Leave the Bathroom
    {
        InBathroom = false;//says that the player isnt in the bathroom 
        bathroomBackground.SetActive(false);//disables the bathroom
        scenes[2].SetActive(true);//enables the bathroom door way
        LeaveButton.gameObject.SetActive(false);//disables the button used to leave the bathroom
    }

    public void NextScene()//Summons the next "scene"
    {
        scenes[currentScene].SetActive(false);//sets the current scene to false
        scenes[currentScene + 1].SetActive(true);//sets next scene to true
        currentScene = currentScene + 1;//updates the current scene
    }
    public void PreviousScene()//Summons previous "scene"
    {
        scenes[currentScene].SetActive(false);//sets current scene to false
        scenes[currentScene - 1].SetActive(true);//sets the previous scene to true
        currentScene = currentScene - 1;//updates the current scene
    }
    public void DoorOpen()//opens the door to the bathroom
    {
        if (bathroomOpen == true)//checks if the door is unlocked
        {
            InBathroom = true;//says we are in the bathroom
            bathroomBackground.SetActive(true);//Sets the bathroom to active
            scenes[currentScene].SetActive(false);//sets the hallway to inactive
            LeaveButton.gameObject.SetActive(true);//turns on the button used to lead
            NextButton.interactable = false;//Disables Button
           PrevButton.interactable = false;//Disables Button
        }
        else//If door is locked
        {
            display.text = dialogue[0];//grabs Dialogue from array
            StartCoroutine(resetText());//Resets the Text box
        }
    }

    public void ToasterClicked()//used when the toaster is clicked
    {
        toasterKey = toasterKey + 1;//increases toaster key
        display.text = dialogue[1];//grabs Dialogue from array
        StartCoroutine(resetText());//Resets the Text box
    }

    public void OldManTalk()//used when the old man is clicked
    {
        display.text = dialogue[2];//grabs Dialogue from array
        textResetTime = 5f;//Changes the time it takes for text to disapear
        StartCoroutine(resetText());//Resets the Text box
        textResetTime = 1f;//Changes the time it takes for text to disapear
    }

    public void FoundMeds()
    {
        display.text = dialogue[3];//grabs Dialogue from array
        OldMan.SetActive(false);//removes the old man
    }

    public IEnumerator resetText()//resets the text box
    {
        yield return new WaitForSeconds(textResetTime);//Delays the Reset
        display.text = "";//Replaces previous Text with blank
        StopCoroutine(resetText());//Stops reseting 
    }

    public void ButtonController()// controlls the buttons based on the length of the scene Array
    {
        if (currentScene == scenes.Length - 1)//if at the end of the Array
        {
            NextButton.interactable = false;
        }
        else
        {
            NextButton.interactable = true;
        }
        if (currentScene == 0)//if at the start if the Array
        {
            PrevButton.interactable = false;
        }
        else if (InBathroom == false)//if not in the bathroom
        {
            PrevButton.interactable = true;
        }
    }

}
