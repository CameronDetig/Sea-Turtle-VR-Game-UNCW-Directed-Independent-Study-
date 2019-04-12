using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirahna : MonoBehaviour
{
    float speed = .75f;
    float width = 5;
    float length = 5;

    float timeCounter = 0;

    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float PirahnaX = Mathf.Cos(timeCounter) * width;
        //float PirahnaY = Mathf.Cos(timeCounter) * .1f;
        float PirahnaY = 1;
        float PirahnaZ = Mathf.Sin(timeCounter) * length;

        transform.position = new Vector3(PirahnaX, PirahnaY, PirahnaZ);
        //transform.Rotate(Vector3.up * (width * length * speed) * Time.deltaTime);
        transform.Rotate(0, -speed, 0);
    }
}
