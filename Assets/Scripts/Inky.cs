using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Ink.Runtime;
using System;

public class Inky : MonoBehaviour
{

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject questionsPanel;

    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayName;

    public CheckList CL;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;



    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }
    bool canContinueToNextLine;
    bool canContinue;

    private static Inky instance;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Instance of Dialogue Manager");
        }
        instance = this;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        questionsPanel.SetActive(false);
       


        //get the choices
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }


    }
    private void Update()
    {
        //no dialogue to play. returns
        if (!dialogueIsPlaying)
        {
            return;
        }
        if (canContinueToNextLine
            && currentStory.currentChoices.Count == 0)
        {
            ContinueStory();
            Debug.Log("can Cotinue");
        }
        if (Input.GetKeyDown(KeyCode.Backspace) && dialogueIsPlaying == true)
        {
            StartCoroutine(ExitDialogueMode());
        }
        
    }

    public static Inky GetInstance()
    {
        return instance;
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        Debug.Log("DialogueMode");
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        questionsPanel.SetActive(true);
        canContinue = true;
        currentStory.BindExternalFunction("logEvent", (string name) => {
            Debug.Log(name);
        });
        ContinueStory();
    }
    private void ContinueStory()
    {
        /// Look here for exit bug
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            DisplayChoices();
            HandleTags(currentStory.currentTags);
            Debug.Log("Continuing");
        }
       

        if (currentStory.currentChoices.Count <= 0 && !currentStory.canContinue)
        {
            StartCoroutine(ExitDialogueMode());

            Debug.Log("exit ");
        }
    }

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f);
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        questionsPanel.SetActive(false);
        dialogueText.text = "";
        StopCoroutine(ExitDialogueMode());
    }

    private void DisplayChoices()
    {


        List<Choice> currentChoices = currentStory.currentChoices;

        //Defence against infinite choices
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More Choices given than are supported by system. Number of choices given:" + currentChoices.Count);
        }

        
        int index = 0;

        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }


    //Event system work around, unknown reasoning
    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
        
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);

        ContinueStory();
    }

    public void HandleTags(List<string> currentTags)
    {
       //Note to self: removed HandleTags may need to reimpliment
    }
}
