using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script is designed to use a raycast to figure oput what the player is clicling and if it has a corrisponding action it then calls that action
public class Clicker : MonoBehaviour
{
    [SerializeField] string obName = null;

    public Events eventScript;

    private void Start()
    {
        eventScript = FindObjectOfType<Events>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Mouse Input
        {

            

            RaycastHit2D Hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (Hit.collider !=null)
            {
                obName = Hit.transform.name;
                Debug.Log(obName);
            }
        }
        if (obName == "Door")
        {
            eventScript.DoorOpen();
            obName = "None";
        }
        if (obName == "Toaster")
        {
            eventScript.ToasterClicked();
            obName = "None";   
        }
        if (obName == "OldMan")
        {
            eventScript.OldManTalk();
            obName = "None";
        }
        if(obName == "Meds")
        {
            eventScript.FoundMeds();
        }
    }
}
