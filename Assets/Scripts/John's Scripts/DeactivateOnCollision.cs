using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnCollision : MonoBehaviour
{
    // Tag of other object that will deactive this object on collision
    [SerializeField] private string destroyTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(destroyTag))
            gameObject.SetActive(false);
    }
}
