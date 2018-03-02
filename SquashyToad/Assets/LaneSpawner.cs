using UnityEngine;
using System.Collections;

public class LaneSpawner : MonoBehaviour {

    public GameObject[] safeLanePrefabs;
    public GameObject[] dangerLanePrefabs;
    public int numberOfLanes;
    private int offset=0;
    private int laneOffset;
    public GameObject frog;
    // Use this for initialization
    void Start()
    {
        laneOffset = numberOfLanes * 50;
        
    }
    void Update () {
        
        while (offset< laneOffset + frog.transform.position.z)
        {
            CreateRandomDangerLane(offset);
            offset += 50;
            CreateRandomSafeLane(offset);
            offset += 50;
        }
        foreach (Transform laneTransform in this.transform)
        {
            if (laneTransform.position.z + laneOffset < frog.transform.position.z)
            {
                Destroy(laneTransform.gameObject);
            }
        }
    }
	
    void CreateRandomSafeLane(float offset)
    {
        
        var lane = InstantiateRandomLane(safeLanePrefabs);
        lane.transform.SetParent(transform, false);
        lane.transform.Translate(0, 0, offset);
    }
    void CreateRandomDangerLane(float offset)
    {
        
        var lane = InstantiateRandomLane(dangerLanePrefabs);
        lane.transform.SetParent(transform, false);
        lane.transform.Translate(0, 0, offset);
    }
    GameObject InstantiateRandomLane(GameObject[] lanes)
    {
        int laneIndex = Random.Range(0, lanes.Length);
        return Instantiate(lanes[laneIndex]);
       
    }
    // Update is called once per frame
    
}
