using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanessa : GameBehaviour
{
    public GameObject vanessa;
    public int loopNo = 2;

    private void Start()
    {
        vanessa.SetActive(false);
    }
    void Update()
    {
        if (_LOOP.loop >= loopNo)
        {
            vanessa.SetActive(true);
            Debug.Log("APPEAR");
        }
    }
}
