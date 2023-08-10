using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeChange : MonoBehaviour
{

    /// <summary>
    /// This is a temporary script that changes the text in the beginning scene.
    /// </summary>
    
    public TMP_Text time;
    public void SleepIn()
    {
        time.text = ("7:30AM");
    }

    public void SleepInAgain()
    {
        time.text = ("8:00 AM");
    }

    public void SleepFinal()
    {
        time.text = ("... Shit I'm Late!");
    }
}
