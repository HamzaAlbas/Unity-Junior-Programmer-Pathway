using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnDelay = 2;
    public float spawnInterval = 1.5f;

    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, spawnPosZ);
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[randomIndex], spawnPos, transform.rotation);
    }
}
