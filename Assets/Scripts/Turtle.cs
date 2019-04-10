using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    public Spawner spawn;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Animated Bag(Clone)")
        {
            print("Bag Hit. counter = " + spawn.bagHitCounter);
            spawn.bagHitCounter += 1;
        }
    }
}
