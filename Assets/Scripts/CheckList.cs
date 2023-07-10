using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckList : MonoBehaviour
{
    public int Points;
    public MyStruct[] structArray;
    [System.Serializable]
    public struct MyStruct
    {
        public string Event;
        public bool Check;
        public int pointValue;
    }


   
    public void CalculatePoints()
    {
        for (int i = 0; i < structArray.Length; i++)
        {
            if (structArray[i].Check == true)
            {
                Points = Points + structArray[i].pointValue;
            }
        }
        DefaultPoints();

    }
    public void DefaultPoints()
    {
        Points = 0;
    }

}
