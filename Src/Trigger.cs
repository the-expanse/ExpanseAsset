using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    Renderer renderer;

    void Start() {
        renderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other) {
        renderer.sharedMaterial.color = Color.red;
    }

    void OnTriggerExit(Collider other) {
        renderer.sharedMaterial.color = Color.green;
    }
}