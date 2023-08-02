using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Ink.Runtime;

public class Inky : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject questionsPanel;
    //[SerializeField] private GameObject journal;

    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayName;



    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;



    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }



    private const string SPEAKER_TAG = "speaker";
    private const string EMOTE = "emote";

    //needed for freezing player
    public GameObject player;
    public GameObject NPC;
    public Rigidbody2D rB;
    public GameObject journal;


    private void Awake()
    {
      
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        questionsPanel.SetActive(false);
        rB = player.GetComponent<Rigidbody2D>();


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
        
        if (Input.GetKeyDown(KeyCode.Backspace) && dialogueIsPlaying == true)
        {
            ExitDialogueMode();
        }
    }

  
    public void EnterDialogueMode(TextAsset inkJSON)
    {
        Debug.Log("DialogueMode");
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        questionsPanel.SetActive(true);
        NPC.SetActive(true);


        
        ContinueStory();
    }
    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();

            DisplayChoices();

            HandleTags(currentStory.currentTags);
        }
        else
        {
            //ExitDialogueMode();

            Debug.Log("exit cant continue");
        }
    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        questionsPanel.SetActive(false);
        dialogueText.text = "";
       

        NPC.SetActive(false);
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
        //bardSpeak = false;
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }

    public void HandleTags(List<string> currentTags)
    {
        //parse the tag
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriatly parsed:" + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();


            switch (tagKey) //change out for if statement
            {
                case SPEAKER_TAG:
                    displayName.text = tagValue;
                    Debug.Log("speaker =" + tagValue);
                    break;
                case EMOTE:
                    break;


                default:
                    Debug.LogWarning("Tag came in but is not currently being handled:" + tag);
                    break;
            }
        }
    }
}
