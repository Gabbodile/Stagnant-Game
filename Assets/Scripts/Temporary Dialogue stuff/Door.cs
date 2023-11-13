using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject nextRoom;

    private void OnMouseDown()
    {
        nextRoom.SetActive(true);
    }
}
