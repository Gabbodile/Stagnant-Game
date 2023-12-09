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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reactivate()
    {

        fadeScreen.DOFade(1, 0.001f);
        fadeScreen.DOFade(0, 1);

    }

    
}
