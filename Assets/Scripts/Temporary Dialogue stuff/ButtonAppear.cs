using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAppear : MonoBehaviour
{
    public GameObject button;

    private void OnMouseDown()
    {
        button.SetActive(true);
    }
}
