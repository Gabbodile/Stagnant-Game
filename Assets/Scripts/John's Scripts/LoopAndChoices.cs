using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAndChoices : GameBehaviour<LoopAndChoices>
{
    /// <summary>
    /// Holds the values for the current loop, and the number of good and bad choices the player has made
    /// </summary>

    public int loop;
    public int goodChoices;
    public int badChoices;

    [Header("Choice Bools")]
    public bool hasShowered;
    public bool hasEaten;
    public bool hasLaundry;


    private static LoopAndChoices instance;

    //private void Awake()
    //{
    //    if (instance != null)
    //    {
    //        Debug.LogWarning("Found more than one Loop and Choices Manager in the scene");
    //    }
    //    instance = this;
    //}
    private void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Loop and Choices Manager in the scene");
        }
        instance = this;
    }

    public static LoopAndChoices GetInstance()
    {
        return instance;
    }

    public void IncreaseLoop()
    {
        loop++;
        hasShowered = false;
        Debug.Log("Loop increased");
    }

    public void IncreaseGoodChoices(int _increaseValue)
    {
        goodChoices += _increaseValue;
    }

    public void IncreaseBadChoices(int _increaseValue)
    {
        badChoices += _increaseValue;
    }
}
