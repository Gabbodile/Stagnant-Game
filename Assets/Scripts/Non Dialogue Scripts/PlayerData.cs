using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : GameBehaviour
{

    public int score;
    public int highScore;
    public string playTime;

    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            score++;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Save();
        }
    }

    void Save()
    {
      
    }
}
