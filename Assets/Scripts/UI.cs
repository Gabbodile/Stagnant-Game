using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;

public class UI : MonoBehaviour
{
    public TMP_Text DialogueBox;
    public Image PortraitDisplay;
    public GameObject panel;
    public Button closePanel;
    public GameObject pausePanel;
    public static bool isPaused = false;
    public GameObject Phone;
    public Vector2 endPoint;
    public Vector2 startPoint;
    public bool PhoneInUse;
    public void Start()
    {
        panel.SetActive(false);
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
    public void DialogueActivate()
    {
        panel.SetActive(true);
    }
    public void closePanelFuncion()
    {
        panel.SetActive(false);
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
        if (PhoneInUse == true)
        {
            startPoint = Phone.transform.position;
            Phone.transform.DOMove(endPoint, 1f, true);
        }
       else if (PhoneInUse == false)
        {
            Phone.transform.DOMove(startPoint, 1f, true);
        }
        
    }
}
