using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour
{

    // Use this for initialization

    void OnTriggerEnter(Collider col)
    {
        Destroy(col.GetComponentInParent<Rigidbody>().gameObject);
    }
}
