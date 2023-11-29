using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laundry : GameBehaviour
{
    /// <summary>
    /// Manages all the clothes pile objects in the scene
    /// </summary>

    // the first loop at which the dragging option becomes avalable
    [SerializeField] private int startingLoop = 1;

    public GameObject[] clothesPiles;

    private void OnMouseDown()
    {
        // enables laundry after the first loop
        if (startingLoop > _LOOP.loop)
            return;

        for (int i = 0; i < clothesPiles.Length; i++)
        {
            clothesPiles[i].GetComponent<ItemGlow>().donttalking = true;
            clothesPiles[i].GetComponent<DragableObject>().activated = true;
            clothesPiles[i].GetComponent<DialogueTrigger>().disabled = true;
            Debug.Log("LaundryEnabled");
        }
    }
}
