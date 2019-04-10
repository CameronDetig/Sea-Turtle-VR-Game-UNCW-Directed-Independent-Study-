using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFish : MonoBehaviour
{
    public float speed = .5f;
    public GameObject turtle;

    void Start()
    {
        turtle = GameObject.FindWithTag("Turtle");
    }

    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, turtle.transform.position, step);
    }
}
