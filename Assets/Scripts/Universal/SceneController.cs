using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : GameBehaviour<SceneController>
{
    // Will change the scene to the string passed in
    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    // Will increase the loop the gamme is on
    public void Loop()
    {
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
