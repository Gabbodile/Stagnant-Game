using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Ink.Runtime;

public class PhoneUI : MonoBehaviour
{
    public GameObject phoneMenu;
    public Animator anim;
    public GameObject phoneConent;
    public GameObject resetPoint;
    public GameObject targetPoint;
    public bool isActive;
    public bool isHovered;
    public bool hasClicked;
    public float timeElapsed;
    public float lerpDuration = 2;
    public float valueToLerp;
    
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        isHovered = false;
        hasClicked = false;
        phoneConent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        anim = phoneMenu.GetComponent<Animator>();
    }



    public void ActivatePhone()
    {
        if (!isActive)
        {
            //phoneMenu.transform.DOMove(new Vector2(targetPoint), 1);
            Vector2 reset = resetPoint.transform.position;
            Vector2 target = targetPoint.transform.position;
            phoneMenu.transform.position = Vector2.Lerp(reset, target, 1);
            //phoneMenu.transform.position = target;
            isActive = true;
            phoneConent.SetActive(true);
            anim.SetTrigger("Active");

        }
        else
        {
            Vector2 reset = resetPoint.transform.position;
            Vector2 target = targetPoint.transform.position;
            phoneMenu.transform.position = Vector2.Lerp(target, reset, Time.deltaTime * 2f);
            phoneMenu.transform.position = reset;
            isActive = false;
            phoneConent.SetActive(false);
            anim.SetTrigger("Deactivate");
        }
    }

    public void StartPhone()
    {
        StartCoroutine(OpenPhone());
    }

    public void OnClickPhone()
    {
        if (!isActive)
        {
            anim.SetTrigger("Active");
            hasClicked = true;
            isActive = true;

        }
        else
        {
            anim.SetTrigger("Deactivate");
            hasClicked = false;
            isActive = false;
        }
    }

    public void OnHoverPhone()
    {
        if (!hasClicked && !isHovered)
        {
            anim.SetTrigger("Hovering");
            isHovered = true;
        }
    }

    public void OnExitPhone()
    {
        if (!hasClicked)
        {
            anim.SetTrigger("Exit");
            isHovered = false;
        }
    }

    public IEnumerator OpenPhone()
    {
        if(!isActive)
        {
            timeElapsed = 0;
            if (timeElapsed < lerpDuration)
            {
                Vector2 reset = resetPoint.transform.position;
                Vector2 target = targetPoint.transform.position;
                timeElapsed += Time.deltaTime;
                phoneMenu.transform.position = Vector2.Lerp(reset, target, timeElapsed / lerpDuration);
                phoneConent.SetActive(true);
                yield return null;
            }
            phoneMenu.transform.position = targetPoint.transform.position;
            yield return null;
        }
        else
        {
            timeElapsed = 0;
            if (timeElapsed < lerpDuration)
            {
                Vector2 reset = resetPoint.transform.position;
                Vector2 target = targetPoint.transform.position;
                timeElapsed += Time.deltaTime;
                phoneMenu.transform.position = Vector2.Lerp(target, reset, timeElapsed / lerpDuration);
                phoneConent.SetActive(false);
                yield return null;
            }
            phoneMenu.transform.position = resetPoint.transform.position;
            yield return null;
        }
        
    }

}
