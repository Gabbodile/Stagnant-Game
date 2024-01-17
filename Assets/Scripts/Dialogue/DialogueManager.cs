using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;

public class DialogueManager : GameBehaviour<DialogueManager>
{
    [Header("Dialouge UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] private Animator portraitAnimator;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;

    public bool dialogueIsPlaying { get; private set; }
    private bool choicesAreActive;

    //private static DialogueManager instance;

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";



    private void Awake()
    {
        //if (instance != null)
        //{
        //    Debug.LogWarning("Found more than one Dialouge Manager in the scene");
        //}
        //instance = this;

        Instantiate();
    }

    //public static DialogueManager GetInstance()
    //{
    //    return instance;
    //}

    private void Start()
    {
        dialogueIsPlaying = false;
        choicesAreActive = false;
        dialoguePanel.SetActive(false);

        // get all of the choices text
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
        // return right away if dialogue isn't playing
        if (!dialogueIsPlaying)
        {
            return;
        }

        // handle continuing to the next line in the dialogue when you left click
        //if (Input.GetMouseButtonDown(0))
        //{
        //    ContinueStory();
        //}

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            ContinueStory();
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("exited dialogue");
            ExitDialogueMode();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        BindInkExternalFunctions();
        
        // reset portrait and speaker
        displayNameText.text = "???";
        portraitAnimator.Play("Default");

        ContinueStory();
    }

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.1f);

        UnbindInkExternalFunctions();

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    public void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            // set text for the current dialogue line
            dialogueText.text = currentStory.Continue();
            // display choices, if any, for this dialogue line
            DisplayChoices();
            if (choices[0].activeSelf == true)
            {
                choicesAreActive = true;
            }
            // handle tags
            HandleTags(currentStory.currentTags);
        }
        else if (!choicesAreActive)
        {
            StartCoroutine(ExitDialogueMode());
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        // loop through each tag and handle it accordingly
        foreach (string tag in currentTags)
        {
            // parse the tag
            string[] splitTag = tag.Split(":");
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriatley parsed: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            // handle the tag
            switch (tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    portraitAnimator.Play(tagValue);
                    break;
                default:
                    Debug.LogWarning("Tag came in but is not currently being handled: " + tag);
                    break;
            }
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        // defensive check to make sure UI can support the number of choices coming in
        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choices given: " + currentChoices.Count);
        }


        // loop through all choice buttons in UI and display them according to the current choices in the INK story
        int index = 0;
        // enable and initialize the choices up to the amount of choices for this line of dialogue
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        // go through the remaining choices the UI supports and make sure they're hidden
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
        choicesAreActive = false;
    }


    public void CloseDialogueButton()
    {
        StartCoroutine(ExitDialogueMode());
    }



    public void TestDialougeTriggerScript(TextAsset inkJSON)
    {
        Debug.Log(inkJSON.text);
    }

    #region Bind and Unbind Ink External Functions
    /// <summary>
    /// I tried placing this stuff into a seperate script but it didn't work
    /// </summary>

    private void BindInkExternalFunctions()
    {
        currentStory.BindExternalFunction("goodChoice", (int increaseValue) =>
        {
            LoopAndChoices.GetInstance().IncreaseGoodChoices(increaseValue);
        });

        currentStory.BindExternalFunction("badChoice", (int increaseValue) =>
        {
            LoopAndChoices.GetInstance().IncreaseBadChoices(increaseValue);
        });

        currentStory.BindExternalFunction("Consumed", (int increaseValue) =>
        {
            LoopAndChoices.GetInstance().DrinksConsumed(increaseValue);
        });

        currentStory.BindExternalFunction("Car", (GameObject car) =>
        {
            LoopAndChoices.GetInstance().CarScene(car);
        });
    }

    private void UnbindInkExternalFunctions()
    {
        currentStory.UnbindExternalFunction("goodChoice");
        currentStory.UnbindExternalFunction("badChoice");
    }

    #endregion
}
