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
    public int counter = 0;

    public int bagHitCounter = 0;
    //public bool gamePlaying = true;     //Will eventually be first initialized to false and later set to true by the UI.


    void Update()
    {
        if (bagHitCounter < 3)          //Ends game if three bags hit the turtle.
        { 
            gap -= Time.deltaTime;

            if (gap <= 0)
            {
                int selectObject = Random.Range(1, 5);
                int spawnNum = Random.Range(1, 5);

                var spawnObject = jellyFish;
                var spawnPos = spawn1;

                switch (spawnNum)       //Picks the spawn location.
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

                if (selectObject == 4 || selectObject == 3)  //Half of the objects will be bags.
                {
                    spawnObject = groceryBag;
                }

                Instantiate(spawnObject, spawnPos.transform.position, Quaternion.identity);

                counter += 1;

                if (counter <= 10)                           //Stage 1
                {
                    gap = 2.0f;
                }
                else if (counter > 10 && counter <= 20)      //Stage 2
                {
                    gap = 1.5f;
                }
                else if (counter > 20)                       //Stage 3 (Goes on till end)
                {
                    gap = 1.0f;
                }
            }
        }
    }
}
