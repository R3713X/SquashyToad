using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public GameObject UICanvas;
    public GameObject reticle;
    public void onDeath()
    {
        UICanvas.SetActive(true);
        reticle.SetActive(true);
        transform.GetComponentInParent<Rigidbody>().isKinematic = true;

    } 
}
