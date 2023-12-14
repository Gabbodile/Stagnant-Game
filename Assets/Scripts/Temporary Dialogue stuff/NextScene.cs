using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : GameBehaviour
{
    void Update()
    {
        
    }

    IEnumerator Scene()
    {
        yield return new WaitForSeconds(5);
        //_SC.ChangeScene();
    }
}
