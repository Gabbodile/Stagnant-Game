using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;

public class UI : MonoBehaviour
{
    public GameObject pausePanel;
    public static bool isPaused = false;
    public GameObject Phone;
    public Transform endPoint;
    public Transform startPoint;
    public bool PhoneInUse;

    public string nextLevel;

    public bool increaseLoop;
   

    public void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    
    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Resume");
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Menu()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void UsePhone()
    {
            Debug.Log("Phoen Moving");
            Phone.transform.DOMove(endPoint.position, 1f, true);
    }
    public void DontUsePhone()
    {
        Phone.transform.DOMove(startPoint.position, 1f, true);
    }

    public void Level()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevel);
    }

    public void Loop()
    {
        if (increaseLoop)
        {
            LoopAndChoices.GetInstance().IncreaseLoop();
            Debug.Log(LoopAndChoices.GetInstance().loop);
        }
    }

}
