using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
        RenderSettings.fogDensity = 0.045f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
