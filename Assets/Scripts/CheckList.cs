using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckList : MonoBehaviour
{
    public EnergySystem ES;
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
        ES.ELevels();
        StartCoroutine(DefaultPoints());

    }
    public IEnumerator DefaultPoints()
    {
        yield return new WaitForSeconds(1);
        Points = 0;
        StopCoroutine(DefaultPoints());
    }

}
