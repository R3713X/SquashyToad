using UnityEngine;
using System.Collections;

public class LethalComponent : MonoBehaviour {

    private Death deathComponent;

    void Start()
    {
        deathComponent = FindObjectOfType<Death>();
    }

    void OnCollisionEnter(Collision collision)
    {
        deathComponent.onDeath();
    }

}
