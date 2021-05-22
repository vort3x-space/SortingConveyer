using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class belt : MonoBehaviour {

    public float speed = 3.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rigi = collision.collider.GetComponent<Rigidbody>();
        rigi.velocity = this.transform.right * speed;
        
    }
    
}
