using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolling : MonoBehaviour {
    private Vector3 euler;
	// Use this for initialization
	void Start () {
        euler = this.transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
        euler.x -= Time.deltaTime*100.0f;
        this.transform.rotation = Quaternion.Euler(euler);

    }
}
