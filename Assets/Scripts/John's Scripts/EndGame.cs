using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : GameBehaviour
{
    public GameObject goodVanessa;
    public GameObject badNess;

    public void Decide()
    {
        if (_LOOP.goodChoices >= _LOOP.badChoices)
        {
            Debug.Log("Good end");
            goodVanessa.SetActive(true);
            badNess.SetActive(false);
        }
        else
        {
            Debug.Log("Bad end");
            badNess.SetActive(true);
            goodVanessa.SetActive(false);
        }
            
    }


    /// <summary>
    /// Everything that is required for the good ending to play out goes here (e.g. activating and deactivating certain objects)
    /// </summary>
    //void GoodEnding()
    //{
    //    Debug.Log("Good Ending");
    //    goodVanessa.SetActive(true);
    //}

    /// <summary>
    /// Everything that is required for the bad ending to play out goes here (e.g. activating and deactivating certain objects)
    /// </summary>
//    void BadEnding()
//    {
//        Debug.Log("Bad Ending");
//        badNess.SetActive(true);
//    }
}
