using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {
    public float spawnIntervalBasic = 2;
    public float spawnIntervalMin = 0.3f;
    public float spawnIntervalMax = 2;
    float nextSpawnTime = 0;
    public GameObject vehiclePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + spawnIntervalBasic + Random.Range(spawnIntervalMin, spawnIntervalMax);
        }
	}
    void Spawn()
    {
        var vehicle = Instantiate(vehiclePrefab, transform.position, transform.rotation, transform);
    }
}
