using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock4Key : MonoBehaviour
{
    public CheckList _CL1;
    public GameObject Lock;
    public int key1, key2, key3, key4;
    bool Lock1;
    bool Lock2;
    bool Lock3;
    bool Lock4;

    public void UnlockThing4()
    {
        if (_CL1.structArray[key1].Check == true)
        {
            Lock1 = true;
        }

        if (_CL1.structArray[key2].Check == true)
        {
            Lock2 = true;
        }
        if (_CL1.structArray[key3].Check == true)
        {
            Lock3 = true;
        }
        if (_CL1.structArray[key4].Check == true)
        {
            Lock4 = true;
        }

        if (Lock1 == true && Lock2 == true && Lock3 == true && Lock4 == true)
        {
            Lock.gameObject.SetActive(true);
        }
    }
}
