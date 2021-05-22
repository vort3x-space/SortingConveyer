using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Sorter : MonoBehaviour {
    public bool done = true;

    public void push(Transform t)
    {
        if (done)
        {
            done = false;
            t.DOLocalJump(t.localPosition, 2.0f, 1, 0.8f).OnComplete(delegate() { done = true; });
        }
            
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Package")
        {
            collision.collider.GetComponent<Rigidbody>().AddForce(this.transform.up*5.0f);
        }
    }

}
