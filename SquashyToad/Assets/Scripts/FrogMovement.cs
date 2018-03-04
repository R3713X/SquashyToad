using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {
    public int[] jumpSpeed = { 20, 40, 60 };
    public int jumpDegree=45;
    
    public int collisionCounter = 0;
    public int hopCount=0;
    private Vector3 jumpVector;
    private Vector3 unnormalizedJumpVector;
    private Vector3 projectedLookVector;
    private float realJumpDergree;
    private new Camera camera;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        realJumpDergree = Mathf.Deg2Rad * jumpDegree;
        camera = GetComponentInChildren<Camera>();
        rb = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {

        

        bool isOnGround = collisionCounter > 0;
        if (isOnGround)
        {
            hopCount = 0;
        }
        if ( GvrViewer.Instance.Triggered && hopCount<jumpSpeed.Length-1)
        {

            projectedLookVector = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
            unnormalizedJumpVector = Vector3.RotateTowards(projectedLookVector.normalized , Vector3.up, realJumpDergree, 0);
            jumpVector = unnormalizedJumpVector.normalized * jumpSpeed[hopCount];
            rb.velocity = Vector3.zero;
            rb.AddForce(jumpVector, ForceMode.VelocityChange);
            hopCount++;
        }
       
        
    }

    void OnCollisionEnter()
    {
        collisionCounter++;
        
    }
    void OnCollisionExit()
    {
        collisionCounter--;
    }
}
