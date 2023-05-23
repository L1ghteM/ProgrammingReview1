using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;  // The object to follow
    public float speed = 5f;  // The speed of movement

    private void Update()
    {
        // Check if the target object exists
        if (target != null)
        {
            // Calculate the direction to the target
            Vector3 direction = target.position - transform.position;

            // Calculate the distance to the target
            float distance = direction.magnitude;

            // Normalize the direction vector
            direction.Normalize();

            // Check if the object is not already at the target
            if (distance > 0.1f)
            {
                // Move the object towards the target
                transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}
