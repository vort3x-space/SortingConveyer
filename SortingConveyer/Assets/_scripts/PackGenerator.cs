using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PackGenerator : MonoBehaviour {

    public int packageCount = 10;
    public float duration = 2.0f;

    public Transform startPos;
    public Text uiLeftPack;
    private float cTime;
    private int cCount;
	// Use this for initialization
	void Start () {
        cTime = duration;
        cCount = packageCount;
        uiLeftPack.text = cCount.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        cTime -= Time.deltaTime;

        if (cTime <= 0)
        {
            if (cCount > 0)
            {
                cCount--;
                cTime = duration;
                //生成货物
                GameObject obj = Resources.Load<GameObject>("Package");
                //随机货物大小 外观
                obj = Instantiate(obj) as GameObject;
                obj.transform.localScale = new Vector3(0.2f + Random.Range(0.0f, 0.15f), 0.2f + Random.Range(0.0f, 0.15f), 0.2f + Random.Range(0.0f, 0.1f));
                obj.transform.position = startPos.position;
                string des = Random.Range(0,2).ToString();
                obj.AddComponent<Package>().des = des;
                uiLeftPack.text = cCount.ToString();
            }
            else
            {
                this.transform.DOScaleX(1, 5.0f).OnComplete(delegate ()
                {
                    Messenger.Broadcast("End");
                });
                this.enabled = false;
            }
        }
	}
}
