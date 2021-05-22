using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour {

    public static LevelManager level;
    public static PackGenerator pack;
    public static UIcontroller ui;
    private void Start()
    {
        level = this.GetComponent<LevelManager>();
        pack = this.GetComponent<PackGenerator>();
        ui = this.GetComponent<UIcontroller>();
    }
}
