using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReporter : MonoBehaviour
{
    public CheckList CL;
    public string EventName;
    public bool isKey;
    public bool usesEnergy;

    public void Interacted()
    {
        for (int i = 0; i < CL.structArray.Length; i++)
        {
            if (CL.structArray[i].Event == EventName)
            {
                CL.structArray[i].Check = true;
            }
            else if (CL.structArray[i].Event != EventName)
            {
                CL.structArray[i].Check = CL.structArray[i].Check;
            }
        }

    }
}
