using UnityEngine;
using System.Collections;

public class HUDRotation : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        var camera = transform.parent.GetComponentInChildren<Camera>() ;
        var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
        transform.rotation = Quaternion.LookRotation(projectedLookDirection);
    }
}
