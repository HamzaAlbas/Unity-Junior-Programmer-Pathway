using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos;
    public float startDelay;
    public float repeatRate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObjectSpawner", startDelay, repeatRate);
    }

    private void ObjectSpawner()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation, transform);
    }
}
