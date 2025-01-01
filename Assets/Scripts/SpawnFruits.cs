using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    public float xPosition;
    public float boundaryLeft = -10.0f;
    public float boundaryRight = 10.0f;
    public float yDefaultValue = 4.5f;
    public GameObject[] Spawner;
    private int activeFruit = 0;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeFruit <= 0) 
        {
            Debug.Log("No fruits left, spawning new fruits...");
            Spawn();
        }
    }

    void Spawn()
    {
        int fruitCount = UnityEngine.Random.Range(1, 3);
        for (var i = 0; i < fruitCount; i++) {
            int randomIndex = UnityEngine.Random.Range(0, Spawner.Length);
            GameObject randomFruit = Spawner[randomIndex];

            float randomX = UnityEngine.Random.Range(boundaryLeft, boundaryRight);
            Instantiate(randomFruit, new Vector3(randomX, yDefaultValue, 0), Quaternion.identity);
            activeFruit++;
            Debug.Log("fruit spawned at " + randomX);
        }
    }

    public void OnFruitPickedUp() 
    {
        activeFruit--;
    }

    public void OnFruitMissed() 
    {
        activeFruit--;
    }
}
