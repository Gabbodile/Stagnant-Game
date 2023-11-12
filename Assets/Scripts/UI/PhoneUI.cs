using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PhoneUI : MonoBehaviour
{
    public GameObject phoneMenu;
    public GameObject phoneConent;
    public bool isActive;
    public bool isHovered;
    
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        isHovered = false;
        phoneConent.SetActive(false);
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
            phoneConent.SetActive(true);

        }
        else
        {
            phoneMenu.transform.DOMoveY(-70, 1);
            isActive = false;
            phoneConent.SetActive(false);
        }
    }

    public void HoverPhone()
    {
        if (!isHovered)
        {
            phoneMenu.transform.DOMoveY(30, 1);
            isHovered = true;
            phoneConent.SetActive(true);

        }
        
        if(isHovered && !isActive)
        {
            phoneMenu.transform.DOMoveY(-70, 1);
            isHovered = false;
            phoneConent.SetActive(false);
        }
    }
}
