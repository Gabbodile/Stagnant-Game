using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject openDrawer;

    private void Start()
    {
        openDrawer.SetActive(false);
    }
    private void OnMouseDown()
    {
        openDrawer.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
