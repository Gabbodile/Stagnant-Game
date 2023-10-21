using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    public GameObject[] objectsToDestroy;

    public void EnableLaundry()
    {
        Debug.Log("LaundryEnabled1");
        for (int i = 0; i < objectsToDestroy.Length; i++)
        {
            //objectsToDestroy[i].gameObject.tag = "Drag";  //literally useless now
            objectsToDestroy[i].GetComponent<ItemGlow>().donttalking = true;    //needs to be reworked as part of loop system
            Debug.Log("LaundryEnabled");
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided");

        for (int i = 0; i < objectsToDestroy.Length; i++)
        {
            if (collision.gameObject.name == objectsToDestroy[i].name)
            {
                Debug.Log("deactivate");
                collision.gameObject.SetActive(false);
            }
        }
    }*/
}
