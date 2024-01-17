using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject pictureFrame;
    public GameObject dialogue;
    public bool isShowing;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (dialogue.activeInHierarchy == false)
        {
            pictureFrame.SetActive(false);
            isShowing = false;
        }
            
    }
    private void OnMouseDown()
    {
        pictureFrame.SetActive(true);
        isShowing = true;
    }
}
