using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ScreenFader : GameBehaviour<ScreenFader>
{
    public Image fadeScreen;
    public GameObject fader;
    public GameObject carDay;
    public GameObject carNight;
    public bool isDayTime;

    
    // Start is called before the first frame update
    void Start()
    {
        fadeScreen.DOFade(0, 1);
        carDay.SetActive(false);
        carNight.SetActive(false);
        print("isFading");
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

    public void FadeOut()
    {
        fadeScreen.DOFade(1, 1);
    }

    IEnumerator changeToCar()
    {
        FadeOut();
        print("fadingOut");
        yield return new WaitForSeconds(1.2f);
        Reactivate();
        print("GoingToCar");
        if (isDayTime)
        {
            carDay.SetActive(true);
            carNight.SetActive(false);
        }
        else
        {
            carDay.SetActive(false);
            carNight.SetActive(true);
        }
        print("inCar");
        yield return new WaitForSeconds(2f);
        FadeOut();
        print("fadingOutAgain");
        yield return new WaitForSeconds(1.2f);
        carDay.SetActive(false);
        carNight.SetActive(false);
        _SC.ChangeScene("Office");
    }

    public void StartCar()
    {
        StartCoroutine(changeToCar());
    }


}
