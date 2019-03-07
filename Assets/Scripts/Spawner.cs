using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject jellyFish;
    public GameObject groceryBag;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;

    public float gap = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gap -= Time.deltaTime;

        if (gap <= 0)
        {
            int selectObject = Random.Range(1, 5);
            int spawnNum = Random.Range(1, 5);

            var spawnObject = jellyFish;
            var spawnPos = spawn1;

            switch (spawnNum)
            {
                case 1:
                    spawnPos = spawn1;
                    break;
                case 2:
                    spawnPos = spawn2;
                    break;
                case 3:
                    spawnPos = spawn3;
                    break;
                case 4:
                    spawnPos = spawn4;
                    break;
            }

            if (selectObject == 4)
            {
                spawnObject = groceryBag;
            }

            Instantiate(spawnObject, spawnPos.transform.position, Quaternion.identity);

            gap = 2.0f;
        }
        
    }
}
