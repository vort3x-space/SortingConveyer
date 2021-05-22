using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingConveyer : MonoBehaviour {

    public float sensitiveY = 2.0f;
    public Transform obj1;
    public Transform obj2;

    private Vector3 euler;
    private float startEulerY;

	// Use this for initialization
	void Start () {
        euler = this.transform.rotation.eulerAngles;
        Cursor.visible = false;
        startEulerY = euler.y;
	}
	
	// Update is called once per frame
	void Update () {

        float mdx = Input.GetAxis("Mouse Y") * sensitiveY;
        euler.y += mdx;



        obj1.transform.rotation = Quaternion.Euler(euler);
        obj2.transform.rotation = Quaternion.Euler(euler);
        
	}
}
