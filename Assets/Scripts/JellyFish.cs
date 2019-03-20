using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFish : MonoBehaviour
{
    public float speed = .5f;
    public GameObject turtle;

    // Start is called before the first frame update
    void Start()
    {
        turtle = GameObject.FindWithTag("turtle");
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, turtle.transform.position, step);
    }

    //void FixedUpdate()
    //{
    //    GetComponent<Rigidbody>().AddForce(0,1,0);
    //}
}
