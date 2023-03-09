using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, spawnPosZ);
            int randomIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[randomIndex], spawnPos, transform.rotation);
        }        
    }
}
