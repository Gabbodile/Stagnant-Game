using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock1Key : MonoBehaviour
{
    public CheckList _CL1;
    public GameObject Lock;
    public int key1;
    bool Lock1;

    public void UnlockThing1()
    {
        if (_CL1.structArray[key1].Check == true)
        {
            Lock1 = true;
        }
        if (Lock1 == true)
        {
            Lock.gameObject.SetActive(true);
        }
    }
}
