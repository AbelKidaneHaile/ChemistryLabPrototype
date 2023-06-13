using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Reference to the object you want to unspawn
    public GameObject objectToUnspawn;

    // Called when a collision occurs
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with the specified object
        if (collision.gameObject == objectToUnspawn)
        {
            // Unspawn the object
            Destroy(objectToUnspawn);
        }
    }
}
