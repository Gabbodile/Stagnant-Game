using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : GameBehaviour
{

    void Start()
    {
        if (_LOOP.loop < 2)
            return;

        if (_LOOP.goodChoices >= _LOOP.badChoices)
            GoodEnding();
        else
            BadEnding();
    }

    /// <summary>
    /// Everything that is required for the good ending to play out goes here (e.g. activating and deactivating certain objects)
    /// </summary>
    void GoodEnding()
    {
        Debug.Log("Good Ending");
    }

    /// <summary>
    /// Everything that is required for the bad ending to play out goes here (e.g. activating and deactivating certain objects)
    /// </summary>
    void BadEnding()
    {
        Debug.Log("Bad Ending");
    }
}
