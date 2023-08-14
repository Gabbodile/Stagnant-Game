using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock2Key : MonoBehaviour
{
    public CheckList _CL1;
    public GameObject Lock;
    public int key1, key2;
    bool Lock1;
    bool Lock2;
    public void UnlockThing2()
    {
        if (_CL1.structArray[key1].Check == true)
        {
            Lock1 = true;
        }

        if (_CL1.structArray[key2].Check == true)
        {
            Lock2 = true;
        }

        if (Lock1 == true && Lock2 == true)
        {
            Lock.gameObject.SetActive(true);
        }
    }
}
