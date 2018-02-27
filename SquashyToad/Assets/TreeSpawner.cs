using UnityEngine;
using System.Collections;

public class TreeSpawner : MonoBehaviour {
    public GameObject TreePrefab;
    public int minTrees = 10;
    public int maxTrees = 30;
    // Use this for initialization
    void Start () {
        int treenumber;
        treenumber = Random.Range(minTrees, maxTrees);
        for (int i = 0; i < treenumber; i++)
        {
            CreateRandomTree();
        }

    }
    void CreateRandomTree()
    {
        float treeXPosition;
        float treeYPosition;
        treeXPosition = Random.Range(-35,35);
        treeYPosition = Random.Range(-4,4);
        var tree = Instantiate(TreePrefab);
        tree.transform.parent = transform;
        
        tree.transform.localPosition = new Vector3(treeXPosition, -2.5f, treeYPosition);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
