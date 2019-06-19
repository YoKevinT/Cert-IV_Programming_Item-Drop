using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //the fruits we want to spain in as a list
    public GameObject[] fruitsToSpawn;
    //the selected fruit we want to spawn
    public int fruitIndex;
    //time that we want to spawn the fruit
    public float spawnTimer;
    //the count up timer
    public float timer;
    void Start()
    {
        //Ranger with integer is not exclusive with the Max.(max not included)
        fruitIndex = Random.Range(0, fruitsToSpawn.Length);
        //Only Range with float is inclusive with the Max.(max is included)
        spawnTimer = Random.Range(1.0f, 5.0f);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            Instantiate(fruitsToSpawn[fruitIndex], this.transform.position, Quaternion.identity);
            timer = 0;
            //Ranger with integer is not exclusive with the Max.(max not included)
            fruitIndex = Random.Range(0, fruitsToSpawn.Length);
            //Only Range with float is inclusive with the Max.(max is included)
            spawnTimer = Random.Range(1.0f, 5.0f);
        }
    }
}
