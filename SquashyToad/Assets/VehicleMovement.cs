using UnityEngine;
using System.Collections;

public class VehicleMovement : MonoBehaviour {
    public float velocity = 100;
    public Rigidbody rb;
    private Vector3 rotation;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
       
    }
	
	
    void FixedUpdate()
    {
        //rotation = new Vector3(transform.localRotation.x,transform.localRotation.y);
        rb.MovePosition(transform.position-transform.right*velocity*Time.deltaTime);
    }
}
