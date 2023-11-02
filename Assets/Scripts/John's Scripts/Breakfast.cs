using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : MonoBehaviour
{
    public GameObject nextSceneButton;

    private void OnMouseDown()
    {
        nextSceneButton.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
