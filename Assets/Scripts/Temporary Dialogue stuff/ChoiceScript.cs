using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChoiceScript : GameBehaviour<ChoiceScript>
{
    [Header("Choices")]
    public GameObject choices;
    public bool choiceActive;

    public TMP_Text choice1;
    public string ChoiceOne = "";

    public TMP_Text choice2;
    public string ChoiceTwo = "";

    public TMP_Text choice3;
    public string ChoiceThree = "";

    // Start is called before the first frame update
    void Start()
    {
        choices.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (choiceActive == true)
            choices.SetActive(true);
    }
}
