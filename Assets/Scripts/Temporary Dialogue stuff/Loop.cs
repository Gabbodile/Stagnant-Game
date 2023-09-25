using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Loop : MonoBehaviour
{
    public int loop = 0;
    public TMP_Text loopNumber;

    // Start is called before the first frame update
    void Start()
    {
        loop = 0;
    }

    // Update is called once per frame
    void Update()
    {
        loopNumber.text = "Loop: " + loop;
    }

    public void AddToLoop()
    {
        loop++;
    }

}
