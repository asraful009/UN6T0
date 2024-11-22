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
                    Vector3 collisionNormal = contact.normal;

                    Debug.Log("Collision Normal: " + collisionNormal);

                    // Additional logic here
                }
            }
        }
    }
}
