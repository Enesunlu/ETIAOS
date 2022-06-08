using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private float  spawnRate = 5f;
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] objects;

    private float nextSpawnTime = 0f;
    void Start()
    {
        spawnPositions[0].gameObject.name = "Test";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>nextSpawnTime)
        {
            nextSpawnTime += spawnRate;
            SpawnObject(objects[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);
        }
    }
    private void SpawnObject(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation);
    }
    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnPositions.Length);
    }
    private int RandomObjectNumber()
    {
        return Random.Range(0, objects.Length);
    }
}
