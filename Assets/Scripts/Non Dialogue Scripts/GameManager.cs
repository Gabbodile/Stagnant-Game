using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState{GOOD, NUETRAL, BAD }
public enum GameState { Playing, Paused}
public class GameManager : GameBehaviour<GameManager> 
{
    [SerializeField] public int LoopNumber;

    public GameState gameState;
    public bool isPlaying;

    public void Start()
    {
        gameState = GameState.Playing;
    }

    public void Update()
    {
        if (gameState == GameState.Playing)
        {
            isPlaying = true;
        }
        else
        {
            isPlaying=false;
        }

        if(Input.GetKeyDown(KeyCode.Escape) && isPlaying) 
        {
            
        }
    }

    public void OnPaused()
    {
        
    }

    public void LoopCalculator()
    {
        LoopNumber = LoopNumber + 1;
    }


}
