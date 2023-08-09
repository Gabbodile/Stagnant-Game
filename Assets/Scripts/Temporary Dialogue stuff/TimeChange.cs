using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeChange : MonoBehaviour
{
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
