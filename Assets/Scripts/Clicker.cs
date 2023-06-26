using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script is designed to use a raycast to figure out what the player is clicking and if it has a corrisponding action it then calls that action
public class Clicker : MonoBehaviour
{
    [SerializeField] string obName = null;//Empty string

    public Events eventScript;//Refrences the Event Script

    private void Start()
    {
        eventScript = FindObjectOfType<Events>();//Find the Event scipt in the scene
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Mouse Input
        { 
            RaycastHit2D Hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);//Casts Ray where the mouse is
            if (Hit.collider !=null)//checks if youve hit something
            {
                obName = Hit.transform.name;//grabs the hi bjects name and stores it in the empty string
                Debug.Log(obName);
            }
        }
        if (obName == "Door")//Checks name
        {
            eventScript.DoorOpen();//acivates Function in Event script
            obName = "None";//Resets empty String
        }
        if (obName == "Toaster")//Checks name
        {
            eventScript.ToasterClicked();//acivates Function in Event script
            obName = "None";//Resets empty String   
        }
        if (obName == "OldMan")//Checks name
        {
            eventScript.OldManTalk();//acivates Function in Event script
            obName = "None";//Resets empty String
        }
        if(obName == "Meds")//Checks name
        {
            eventScript.FoundMeds();//acivates Function in Event script
            obName = "None";//Resets empty String
        }
    }
}
