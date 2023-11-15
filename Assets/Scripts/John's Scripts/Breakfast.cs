using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : GameBehaviour
{
    public GameObject nextSceneButton;

    // A bit of tech debt to solve a bug where the choices woulnd't appear when clicking on the cereal
    // My theory is that the problem is with the Kitchen as when I place the object in another room the choices appear
    public GameObject choices;
    public GameObject secondChoice;

    private void OnMouseDown()
    {
        nextSceneButton.SetActive(true);
        //this.gameObject.SetActive(false);

        StartCoroutine(ActivateChoices());
    }

    IEnumerator ActivateChoices()
    {
        choices.SetActive(true);

        yield return new WaitForEndOfFrame();

        if (_TIME.currentTime >= 2)
        {
            Debug.Log("Works");
            secondChoice.SetActive(false);
        }
    }
}
