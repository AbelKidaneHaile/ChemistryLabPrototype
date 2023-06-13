using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveParentAndChild : MonoBehaviour
{
    // Reference to the child object
    public Transform childObject;

    // Called when the parent object is moved
    private void OnMouseDrag()
    {
        // Get the current mouse position in the world
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        // Move the parent object to the new position
        transform.position = mousePosition;

        // Move the child object with the parent
        childObject.SetParent(transform);
    }
}
