using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableObject : GameBehaviour<DragableObject>
{
    private bool dragging = false;
    private Vector3 offset;
    private Vector3 originalLocation;
    private Quaternion originalRotation;
    public bool activated;

    private void Start()
    {
        activated = false;
        originalLocation = transform.position;
        originalRotation = transform.rotation;
    }

    private void Update()
    {
        if (dragging)
        {
            // Move object taking into account the original offset
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        if (!activated)
            return;

        // Record the difference between the object centre and the clicked point on the camera plane
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
        transform.position = originalLocation;
        transform.rotation = originalRotation;
    }
}
