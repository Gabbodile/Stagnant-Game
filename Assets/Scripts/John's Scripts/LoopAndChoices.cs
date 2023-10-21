using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAndChoices : MonoBehaviour
{
    /// <summary>
    /// Holds the values for the current loop, and the number of good and bad choices the player has made
    /// </summary>

    public int loop;
    public int goodChoices;
    public int badChoices;

    private static LoopAndChoices instance;

    private void Awake()
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
