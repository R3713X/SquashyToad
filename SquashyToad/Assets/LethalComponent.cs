using UnityEngine;
using System.Collections;

public class LethalComponent : MonoBehaviour {

    public Death deathComponent;

    void Start()
    {
        deathComponent = FindObjectOfType<Death>();
    }

    void OnCollisionEnter(Collision collision)
    {
        deathComponent.onDeath();
    }

}
