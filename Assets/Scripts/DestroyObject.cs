using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    
    public CheckList checkList;
    public Interact interact;
    public GameObject[] obToDestroy;
    public void Destroy()
    {
        for (int i = 0; i < obToDestroy.Length; i++)
        {
            if (interact.obObject.name == obToDestroy[i].name)
            {
                obToDestroy[i].SetActive(false);
            }
        }
    }
}
