using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanessa : GameBehaviour
{
    public GameObject vanessa;

    private void Start()
    {
        vanessa.SetActive(false);
    }
    void Update()
    {
        if (_LOOP.loop == 3)
            vanessa.SetActive(true);

    }
}
