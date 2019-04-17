using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCube : MonoBehaviour
{
    [HideInInspector]
    public Hand m_ActiveHand = null;

    public Spawner spawn; 

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Recycling")
        {
            print("Start Game");
            spawn.gamePlaying = true;
            Destroy(this.gameObject);
        }
    }
}
