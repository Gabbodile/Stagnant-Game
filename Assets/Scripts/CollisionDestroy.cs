using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    public GameObject[] objectsToDestroy;

    private void OnCollisionEnter2D(Collision2D collision)
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
    }
}
