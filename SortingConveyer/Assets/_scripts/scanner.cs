using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scanner : MonoBehaviour {

    private AudioSource audio;
    private void Start()
    {
        audio = this.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        string s = other.gameObject.GetComponent<Package>().des;
        //Debug.Log(other);

        Messenger.Broadcast<string>("scan",s);
    }
}
