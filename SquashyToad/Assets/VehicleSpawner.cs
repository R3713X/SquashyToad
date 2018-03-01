using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {
    public float meanTime = 1;
    public float spawnIntervalMin = 4;
    float nextSpawnTime = 0;
    public GameObject vehiclePrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time - Mathf.Log(Random.value) * meanTime + spawnIntervalMin;

        }
    }
    void Spawn()
    {
        var vehicle = Instantiate(vehiclePrefab, transform.position, transform.rotation, transform);
    }
}
