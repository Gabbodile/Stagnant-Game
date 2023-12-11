using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    public Image fadeScreen;
    public GameObject fader;
    
    // Start is called before the first frame update
    void Start()
    {
        fadeScreen.DOFade(0, 1);
        fader.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reactivate()
    {
        fadeScreen.DOFade(0, 1);
        fader.SetActive(false);
    }

    
}
