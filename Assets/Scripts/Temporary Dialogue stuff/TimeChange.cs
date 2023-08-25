using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeChange : MonoBehaviour
{

    /// <summary>
    /// This is a temporary script that changes the text in the beginning scene.
    /// </summary>

    public TMP_Text displayTime;
    public TMP_Text time;
    public TMP_Text thoughts;

    private void Start()
    {
        displayTime.text = ("7:00 AM");
    }

    public void SleepIn()
    {
        time.text = ("7:30 AM");
        displayTime.text = ("7:30 AM");
    }

    public void SleepInAgain()
    {
        time.text = ("8:00 AM");
        displayTime.text = ("8:00 AM");
    }

    public void SleepFinal()
    {
        time.text = ("9:00 AM");
        displayTime.text = ("9:00 AM");
    }
}
