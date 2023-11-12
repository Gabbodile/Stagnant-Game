using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PhoneUI : MonoBehaviour
{
    public GameObject phoneMenu;
    public GameObject phoneConent;
    public bool isActive;
    
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void ActivatePhone()
    {
        if(!isActive)
        {
            phoneMenu.transform.DOMoveY(100, 1);
            isActive = true;
        }
        else
        {
            phoneMenu.transform.DOMoveY(-70, 1);
            isActive = false;
        }
    }
}
