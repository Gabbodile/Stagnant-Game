using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom : GameBehaviour
{
    public GameObject cryingGirl;
    public GameObject partyAnimal;
    // Start is called before the first frame update
    void Start()
    {
        _LOOP.bathroom = false;
        cryingGirl.SetActive(false);
        partyAnimal.SetActive(true);
    }

    public void WentBathroom()
    {
        _LOOP.bathroom = true;
    }

    public void Crying()
    {
        if (_LOOP.bathroom == true)
        {
            cryingGirl.SetActive(true);
            partyAnimal.SetActive(false);
        }
    }

}
