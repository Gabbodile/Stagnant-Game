using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;

    [Header("Inky")]
    public TextAsset inkFile;
    public GameObject customButton;
    public GameObject optionPanel;
   
    public bool isTalking = false;

    static Story story;
    //Text nametag;
    //Text message;
    List<string> tags;
    static Choice choiceSelected;


    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();

        story = new Story(inkFile.text);
        tags = new List<string>();
        choiceSelected = null;
    }

    private void Update()
    {
        if (story.canContinue)
        {
            AdvanceDialogue();

            if (story.currentChoices.Count != 0)
                StartCoroutine(ShowChoices());
        }
        else
            EndDialogue();
    }

    void AdvanceDialogue()
    {
        string currentSentence = story.Continue();
        //ParseTags();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(currentSentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = " ";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    IEnumerator ShowChoices()
    {
        Debug.Log("There are some choices to be made");
        List<Choice> _choices = story.currentChoices;

        for(int i = 0; i < _choices.Count; i++)
        {
            //make button. Replace with actual buttons
            GameObject temp = Instantiate(customButton, optionPanel.transform);
            temp.transform.GetChild(0).GetComponent<Text>().text = _choices[i].text;
            temp.AddComponent<Selectable>();
            temp.GetComponent<Selectable>().element = _choices[i];
            temp.GetComponent<Button>().onClick.AddListener(() => { temp.GetComponent<Selectable>().Decide(); });
        }

        optionPanel.SetActive(true);
        yield return new WaitUntil(() => { return choiceSelected != null; });
        AdvanceFromDecision();
    }

    public static void SetDecision(object element)
    {
        choiceSelected = (Choice)element;
        story.ChooseChoiceIndex(choiceSelected.index);
    }

    void AdvanceFromDecision()
    {
        optionPanel.SetActive(false);
        for(int i = 0; i < optionPanel.transform.childCount; i++)
        {
            Destroy(optionPanel.transform.GetChild(i).gameObject);
        }
        choiceSelected = null;
        AdvanceDialogue();
    }


    //void ParseTags()
    //{
    //    tags = story.currentTags;
    //    foreach(string t in tags)
    //    {
    //        string prefix = t.Split(' ')[0];
    //        string param = t.Split(' ')[1];

    //        switch (prefix.ToLower())
    //        {
    //            case "anim":
    //                SetAnimation(param);
    //                break;
    //            case "color":
    //                SetTextColor(param);
    //                break;
    //        }
    //    }
    //}

    public void EndDialogue()
    {
        Debug.Log("End convo");
    }

    //public void StartDialogue(Dialogue dialogue)
    //{
    //    nameText.text = dialogue.name;

    //    sentences.Clear();

    //    foreach(string sentence in dialogue.sentences)
    //    {
    //        sentences.Enqueue(sentence);
    //    }

    //    DisplayNextSentence();
    //}

    //public void DisplayNextSentence()
    //{
    //    if(sentences.Count == 0)
    //    {
    //        EndDialogue();
    //        return;
    //    }

    //    string sentence = sentences.Dequeue();
    //    dialogueText.text = sentence;
    //}


}
