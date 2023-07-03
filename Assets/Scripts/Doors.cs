using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject NewRoom;//The room you want to go to
    public GameObject currentRoom;//The Room your in

    public void OpenDoor()
    {
        NewRoom.SetActive(true);//activates new room
        currentRoom.SetActive(false);//deactivates old room
    }
}
