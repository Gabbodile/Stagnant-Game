using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : GameBehaviour
{
    private void OnMouseDown()
    {
        _LOOP.hasShowered = true;
    }
}
