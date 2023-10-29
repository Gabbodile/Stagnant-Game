using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteThySelf : MonoBehaviour
{
    public GameObject deleteThistm;
    public GameObject wakeup;
    public GameObject alarmClock;
    public GameObject sleep;
    void Start()
    {
        deleteThistm.SetActive(true);
        wakeup.SetActive(false);
        alarmClock.SetActive(false);
        sleep.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            deleteThistm.SetActive(false);
            wakeup.SetActive(true);
            alarmClock.SetActive(true);
            sleep.SetActive(true);
        }
    }
}
