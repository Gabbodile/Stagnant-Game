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

    public enum WhereToGo { Home, Office, Bar}
    public WhereToGo whereTo;

    
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
        if(_TIME.currentTime >= 18)
        {
            isDayTime = false;
        }
        else
        {
            isDayTime=true;
        }
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
        //Fading out to the car
        FadeOut();
        print("fadingOut");
        yield return new WaitForSeconds(1.2f);

        //Fade in to the car
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

        //Fading our from the car
        FadeOut();
        print("fadingOutAgain");
        yield return new WaitForSeconds(1.2f);

        carDay.SetActive(false);
        carNight.SetActive(false);

        //Scene transition
        switch (whereTo)
        {
            case WhereToGo.Home:
                _SC.ChangeScene("Home");
                break;
            
            case WhereToGo.Office:
                _SC.ChangeScene("Office");
                break;

            case WhereToGo.Bar:
                _SC.ChangeScene("Bar");
                break;
        }
    }

    public void StartCar()
    {
        StartCoroutine(changeToCar());
    }


}
