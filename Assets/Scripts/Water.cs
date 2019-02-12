using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private Color waterColor;
    private float waterDensity;

    void Start()
    {
        waterColor = new Color(0.22f, 0.65f, 0.77f, 0.5f);
        waterDensity = 0.1f;
    }

    void Update()
    {
        RenderSettings.fogColor = waterColor;
        RenderSettings.fogDensity = waterDensity;
    }
}
