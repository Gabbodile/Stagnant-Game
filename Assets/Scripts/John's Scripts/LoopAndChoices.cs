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
    public bool hasShowered;


    private void Awake()
    {
<<<<<<< Updated upstream
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Loop and Choices Manager in the scene");
        }
        instance = this;
    }
=======
        DontDestroyOnLoad(this.gameObject);

        // Checks to see if there is another UniversalManagers object in the scene. If there is, this object will destroy itself
        if(GameObject.FindGameObjectsWithTag("UniversalManagers").Length > 1)
        {
            Destroy(this.gameObject);
        }

        Instantiate();
    }

    //private void Start()
    //{
    //    if (instance != null)
    //    {
    //        Debug.LogWarning("Found more than one Loop and Choices Manager in the scene");
    //    }
    //    instance = this;
    //}
>>>>>>> Stashed changes

    //public static LoopAndChoices GetInstance()
    //{
    //    return instance;
    //}

    public void IncreaseLoop()
    {
        loop++;
<<<<<<< Updated upstream
=======
        hasShowered = false;
        Debug.Log("Loop increased");
>>>>>>> Stashed changes
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
