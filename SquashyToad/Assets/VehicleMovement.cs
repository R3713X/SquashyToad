using UnityEngine;
using System.Collections;

public class VehicleMovement : MonoBehaviour {
    public float velocity = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-velocity * Time.deltaTime, 0, 0);
	}
}
