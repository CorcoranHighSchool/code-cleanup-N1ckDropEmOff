﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //animal prefabs
    public GameObject[] animalPrefabs;
    //x range
    private float spawnRangeX = 20.0f;
    //z position
    private float spawnPosZ = 20.0f;

    //Start Delay
    private float startDelay = 2.0f;
    //Spawn Interval
    private float spawnInterval = 1.5f;

    //Start is called before the first frame
    void Start()
    {
        InvokeRepeating(spawnmethodName, startDelay, spawnInterval);
    }

    //Method to spawn animals
    private void SpawnRandomAnimal()
    {
        // Choose a random number
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Spawn Position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.0f, spawnPosZ);
        //Spawn Animal
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
