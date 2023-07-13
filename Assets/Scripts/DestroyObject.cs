using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    
    public CheckList checkList;
    public Interact interact;
    public MyStruct[] DestroyArray;
    [System.Serializable] 
    public struct MyStruct
    {
        public int checkReference;
        public GameObject obToDestroy;
    }
    public void Destroy()
    {
        for (int i = 0; i < DestroyArray.Length; i++)
        {
            if (interact.obObject.name == checkList.structArray[DestroyArray[i].checkReference].Event)
            {
                DestroyArray[i].obToDestroy.SetActive(false);
                checkList.structArray[DestroyArray[i].checkReference].Check = true;
            }
        }
    }
}
