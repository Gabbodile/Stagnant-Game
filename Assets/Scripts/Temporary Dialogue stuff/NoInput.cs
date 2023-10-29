using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoInput : MonoBehaviour
{
    public GameObject tutorial;
    public int secondsToWait = 10;
    public int count = 0;

    void Start()
    {
        tutorial.SetActive(false);
    }

    private void Update()
    {
        Debug.Log("Count is at " + count);
        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        if (count == secondsToWait)
            tutorial.SetActive(true);
        else
        {
            count++;
        }

        yield return new WaitForSeconds(secondsToWait);
    }
}
