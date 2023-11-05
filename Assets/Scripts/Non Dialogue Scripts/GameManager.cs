using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState{GOOD, NUETRAL, BAD }
public class GameManager : GameBehaviour<GameManager> 
{
    [SerializeField] public int LoopNumber;
    

    public void LoopCalculator()
    {
        LoopNumber = LoopNumber + 1;
    }
}
