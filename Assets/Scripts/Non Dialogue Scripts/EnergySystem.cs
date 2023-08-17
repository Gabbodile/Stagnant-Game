using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    public CheckList CL;

    public int energyLevels;
    public int LevelA = 5;
    public int LevelB = 10;
    public int LevelC = 15;
    public int LevelD = 20;

    public GameObject[] ListA;
    public GameObject[] ListB;
    public GameObject[] ListC;
    public GameObject[] ListD;

    public void ELevels()
    {
        energyLevels = CL.Points;
        if (energyLevels <= LevelA)
        {
            for (int i = 0; i < ListA.Length; i++)
            {
                ListA[i].SetActive(false);
            }
        }
        if (energyLevels <= LevelB)
        {
            for (int i = 0; i < ListB.Length; i++)
            {
                ListB[i].SetActive(false);
            }
        }
        if (energyLevels <= LevelC)
        {
            for (int i = 0; i < ListC.Length; i++)
            {
                ListC[i].SetActive(false);
            }
        }
        if (energyLevels <= LevelD)
        {
            for (int i = 0; i < ListD.Length; i++)
            {
                ListD[i].SetActive(false);
            }
        }
    }
}
