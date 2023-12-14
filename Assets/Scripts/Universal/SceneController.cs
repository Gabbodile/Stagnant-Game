using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : GameBehaviour<SceneController>
{
    public string sceneName;

    public enum CarTransition { Home, Office, Bar}

    public CarTransition carTransition;
    
    // Will change the scene to the string passed in
    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void LoadBedroom()
    {
        SceneManager.LoadScene("Bedroom");
    }

    public void LoadBar()
    {
        SceneManager.LoadScene("Bar");
    }

    public void LoadOffice()
    {
        SceneManager.LoadScene("Office");
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
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

    public void TransitionFromCar()
    {

        switch(carTransition)
        {
            case CarTransition.Home:
                SceneManager.LoadScene("Home");
                break;

            case CarTransition.Office:
                SceneManager.LoadScene("Office");
                break;

            case CarTransition.Bar:
                SceneManager.LoadScene("Bar");
                break;
        }

    }
}
