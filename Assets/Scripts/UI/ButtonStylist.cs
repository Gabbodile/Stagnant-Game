using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ButtonType { Bedroom, Kitchen, Bathroom, Office, Bar, Car}
public class ButtonStylist : MonoBehaviour
{

    public ButtonType buttonType;
    public Image buttonIcon;
    public TMP_Text buttonText;

    public Sprite bedroomIcon;
    public Sprite kitchenIcon;
    public Sprite bathroomIcon;
    public Sprite officeIcon;
    public Sprite barIcon;
    public Sprite carIcon;

    // Start is called before the first frame update
    void Start()
    {
        EstablishType();
    }

    // Update is called once per frame
    void Update()
    {
        EstablishType();
    }

    public void EstablishType()
    {
        switch (buttonType)
        {
            case ButtonType.Bedroom:
                buttonIcon.sprite = bedroomIcon;
                buttonText.text = "Bedroom";
                break;

            case ButtonType.Kitchen:
                buttonIcon.sprite = kitchenIcon;
                buttonText.text = "Kitchen";
                break;

            case ButtonType.Bathroom:
                buttonIcon.sprite = bathroomIcon;
                buttonText.text = "Bathroom";
                break;

            case ButtonType.Office:
                buttonIcon.sprite = officeIcon;
                buttonText.text = "Office";
                break;

            case ButtonType.Bar:
                buttonIcon.sprite = barIcon;
                buttonText.text = "Bar";
                break;

            case ButtonType.Car:
                buttonIcon.sprite = carIcon;
                buttonText.text = "Car";
                break;
        }
    }
}
