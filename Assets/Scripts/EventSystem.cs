using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public CheckList CL;
    public string EventName;
    
    public void Interacted()
    {
        for(int i = 0; i < CL.structArray.Length; i++)
        {
            if (CL.structArray[i].Event == EventName)
            {
                CL.structArray[i].Check = true;
            }
        }
        
    }
}
