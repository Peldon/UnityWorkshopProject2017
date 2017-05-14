using UnityEngine;
using System.Collections;

public class JumppadTrigger : MonoBehaviour {
    public float force = 1000f;
    void OnTriggerEnter(Collider other) {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        if(rb != null) {
            rb.AddForce(Vector3.up * force);
        }
    }
}
