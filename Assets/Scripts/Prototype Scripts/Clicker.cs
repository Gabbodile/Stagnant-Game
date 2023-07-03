using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script is designed to use a raycast to figure out what the player is clicking and if it has a corrisponding action it then calls that action
public class Clicker : MonoBehaviour
{
    [SerializeField] string obName = null;//Empty string
    [SerializeField] GameObject obObject = null;//Empty gameObject
    [SerializeField] GameObject obObject1 = null;//Empty gameObject

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
                if (Hit.collider.gameObject.tag == "Drag")//checks if the object can be dragged
                {
                    obObject = Hit.collider.gameObject;//sets the object
                }
            }
           
        }
        if (Input.GetMouseButtonUp(0))//Mouse Input
        {
            obObject = obObject1;//Resets the Object
        }

        Vector3 mousePos = Input.mousePosition;//Sets up new Vector 3 that mimics the Mouse Position
        mousePos.z = Camera.main.nearClipPlane;//defaults the Z axis to stop disapearing objects
        obObject.transform.position = Camera.main.ScreenToWorldPoint(mousePos);//Sets the Object to the Mouse Position

        Actions();//Checks for actions
    }

    private void Actions()//Stores Actions
    {
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
        if (obName == "Meds")//Checks name
        {
            eventScript.FoundMeds();//acivates Function in Event script
            obName = "None";//Resets empty String
        }
    }
}
