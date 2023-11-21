using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : GameBehaviour<SceneController>
{
    public string sceneName;
    
    // Will change the scene to the string passed in
    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void LoadBedroom()
    {
        SceneManager.LoadScene("Bedroom");
    }

    // Will increase the loop the gamme is on
    public void Loop()
    {
        //increase saturation
        _SI.IncreaseSaturation();

        _LOOP.IncreaseLoop();
        Debug.Log(_LOOP.loop);
    }

    // Will quit the game
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
