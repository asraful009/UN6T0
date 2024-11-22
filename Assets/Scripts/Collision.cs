using System;
using UnityEngine;

public class Colluation : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach (ContactPoint contact in other.contacts)
            {
                Debug.Log("contact.thisCollider: " + contact.thisCollider.name);
                // Check if the contact point is associated with your object's collider
                if (contact.thisCollider == GetComponent<Collider>())
                {
                    // Get the contact point and collision normal
                    Vector3 contactPoint = contact.point;
                    Vector3 collisionNormal = contact.normal;

                    // Get your object's position (assumes this script is on your GameObject)
                    Vector3 myPosition = transform.position;

                    // Calculate the distance along the normal
                    float normalDistance = Vector3.Dot(contactPoint - myPosition, collisionNormal);

                }
            }
        }
    }         
}
