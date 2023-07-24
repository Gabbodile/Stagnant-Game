using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    public int energyLevels;
    public int LockCheck;
    public int UnlockCheck;
    public GameObject[] LockedObjects;
    public GameObject[] unlockObjects;
    public CheckList CL;


   void EnergyCheck()
   {
        CL.CalculatePoints();
        energyLevels = CL.Points;
   }

    public void LockAcivities()
    {
        if (energyLevels <= LockCheck)
        {
            for (int i = 0; i < LockedObjects.Length; i++)
            {
                LockedObjects[i].SetActive(false);
            }
        }
    }

    public void UnlockActivities()
    {
        if (energyLevels >= UnlockCheck)
        {
            for (int i = 0; i < unlockObjects.Length; i++)
            {
                unlockObjects[i].SetActive(false);
            }
        }
    }
}
