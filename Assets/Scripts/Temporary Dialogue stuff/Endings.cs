using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endings : GameBehaviour<Endings>
{
    public bool endAvailable = false;
    private void Update()
    {
        //Check loop
        if (_LOOP.loop == 3)
            endAvailable = true;
    }
    
    //Vanessa available

    //hasgonebathroom?
    //Hastalkedtocrying?
    //if hasgonebathroom OR Hastalkedtocrying
    //Check ending

    //switch ending   
    //good ending = this many points
    //bad ending = this many points
}
