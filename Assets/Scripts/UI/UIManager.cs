using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : GameBehaviour<UIManager>
{
    public GameObject PausePanel;
    
    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPause()
    {
        PausePanel.SetActive(true);
    }

    public void OnResume()
    {
        PausePanel.SetActive(false);
    }
}
