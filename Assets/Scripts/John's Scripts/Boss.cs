using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : GameBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] public TextAsset inkJSON;
    public bool disabled;


    private void Awake()
    {
        if (_TIME.currentTime >= 4)
        {
            // !_DM.dialogueIsPlaying && !disabled
            StartCoroutine(AngryTalk());
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator AngryTalk()
    {
        yield return new WaitForSeconds(0.1f);
        _DM.EnterDialogueMode(inkJSON);
    }
}
