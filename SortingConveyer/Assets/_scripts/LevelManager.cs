using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Transform[] Containers;

    public int rightPack;
    private int pCount;

    public Text textUIright;//已分拣正确的

    private void Start()
    {
        pCount = this.GetComponent<PackGenerator>().packageCount;
        rightPack = 0;
    }

    private void Update()
    {
        LevelComplete();
        textUIright.text = rightPack.ToString();
    }
    public void LevelComplete()
    {
        int ri = 0;
        foreach(var v in Containers)
        {
            RaycastHit[] hits = Physics.SphereCastAll(v.position-3*Vector3.up, 2.0f,Vector3.up);
            //应该分拣到的类型
            string Type=v.GetComponent<Container>().des;
            foreach(var hit in hits)
            {
                if(hit.collider.tag == "Package")
                {
                    if (hit.collider.GetComponent<Package>().des == Type)
                    {
                        ri++;
                    }
                    //Debug.Log(hit.collider.name);
                }
                if (hit.collider.tag == "asd")
                {
                    if (hit.collider.GetComponent<Package>().des == Type)
                    {
                        ri++;
                    }
                    //Debug.Log(hit.collider.name);
                }
            }
        }
        rightPack = ri;
        //Debug.Log(ri);
    }
}
