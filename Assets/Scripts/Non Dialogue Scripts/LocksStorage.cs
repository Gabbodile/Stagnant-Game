using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class LocksStorage : MonoBehaviour
{
    public GameObject[] locks;
    public void CheckLocks(GameObject gameObject)
    {
        if (gameObject.GetComponent<EventReporter>().isKey == true)
        {
            for (int i = 0; i < locks.Length; i++)
            {
                locks[i].GetComponent<Unlock>().UnlockCheck();
            }
        }
    }
}
