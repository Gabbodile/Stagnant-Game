using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Unlock : GameBehaviour<Unlock>
{
    public Unlock1Key[] oneKey;
    public Unlock2Key[] twoKey;
    public Unlock3Key[] threeKey;
    public Unlock4Key[] fourKey;


    public void UnlockCheck()
    {
        for (int i = 0; i < oneKey.Length; i++)
        {
            oneKey[i].UnlockThing1();
        }
        for (int j = 0; j < twoKey.Length; j++)
        {
            twoKey[j].UnlockThing2();
        }
        for (int k = 0; k < threeKey.Length; k++)
        {
            threeKey[k].UnlockThing3();
        }
        for (int l = 0; l < fourKey.Length; l++)
        {
            fourKey[l].UnlockThing4();
        }
    }

}
