using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHover : MonoBehaviour
{
    public GameObject buttonPanel;
    public bool panelActive;
    
    // Start is called before the first frame update
    void Start()
    {
        buttonPanel.SetActive(false);
        panelActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(!panelActive)
        {
            buttonPanel.SetActive(true);
            panelActive = true;
        }
        else
        {
            buttonPanel.SetActive(false);
            panelActive = false;
        }
    }
}
