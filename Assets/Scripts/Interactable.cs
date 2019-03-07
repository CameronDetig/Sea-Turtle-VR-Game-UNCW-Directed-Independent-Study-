using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public Hand m_ActiveHand = null;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Recycling" || col.gameObject.name == "Turtle")
        {
            print("Collision");
            Destroy(this.gameObject);
        }
    }
}
