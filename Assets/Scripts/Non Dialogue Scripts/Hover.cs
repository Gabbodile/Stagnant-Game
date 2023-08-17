using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UI ui;
    public void OnPointerEnter(PointerEventData eventData)
    {
        ui.UsePhone();
        Debug.Log("using Phone");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ui.DontUsePhone();
    }
}
