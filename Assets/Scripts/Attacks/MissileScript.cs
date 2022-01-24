using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour {
    void Start() {
        // Second parameter determines delay on destruction
        Destroy(transform.gameObject, 5);
    }

    void Update() {
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("do something");
        Destroy(transform.gameObject);
    }
}
