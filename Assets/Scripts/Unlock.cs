using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Unlock : GameBehaviour<Unlock>
{
    public CheckList _CL1;
    public GameObject locks;
    public int[] key;
    

    // Update is called once per frame
    void Update()
    {
        
       
    }
    public void UnlockThing()
    {
        for (int i = 0; i < key.Length; i++)
        {
            if (_CL1.structArray[i].Check == true)
            {
                    locks.gameObject.SetActive(true);
            }
        }
    }
}
