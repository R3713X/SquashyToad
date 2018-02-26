using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {
    public int jumpFactor =5;
    public int jumpDegree=45;
    public float jumpGroundClearance = 1;
    public float speedTolerance=5;
    
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        bool isOnGround = Physics.Raycast(transform.position, -transform.up, jumpGroundClearance);
        Debug.DrawRay(transform.position, -transform.up * jumpGroundClearance);
        var speed = GetComponent<Rigidbody>().velocity.magnitude;
        bool isNearStationary = speed < speedTolerance;
        if ( GvrViewer.Instance.Triggered && isOnGround && isNearStationary)
        {
            var camera = GetComponentInChildren<Camera>();
            Vector3 projectedLookVector = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
            float realJumpDergree = Mathf.Deg2Rad * jumpDegree;
            Vector3 jumpVector = Vector3.RotateTowards((projectedLookVector.normalized) * jumpFactor, Vector3.up, realJumpDergree, 0);
            GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);
            //GetComponent<Rigidbody>().velocity = jumpVector;
        }
	}
}
