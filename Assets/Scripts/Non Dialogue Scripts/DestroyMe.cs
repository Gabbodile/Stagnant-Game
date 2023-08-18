using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    public GameObject thisObject;
    public void IhaveBeenDestroyed()
    {
        thisObject.SetActive(false);
    }
}
