using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class UIcontroller : MonoBehaviour {

    public Text text;
    public Image image;
    public Texture texture;
    public Sprite[] sprites;
    public RectTransform panel;
    public Text endText;

    private void Start()
    {
        Messenger.AddListener<string>("scan", changeText);
        Messenger.AddListener("End", GameEnd);
    }

    public void changeText(string s)
    {

        image.sprite = sprites[int.Parse(s)];
        image.DOFillAmount(1, 0.3f).OnComplete(delegate() {
            image.fillOrigin = 0;
            image.DOFillAmount(1, 0.5f).OnComplete(delegate () {
                image.DOFillAmount(0, 0.3f).OnComplete(delegate() { image.fillOrigin = 1; });
            });
            
        });
        //text.text = s;
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void retry()
    {
        SceneManager.LoadScene("main");
    }
    public void GameEnd()
    {
        panel.DOMoveY(Screen.height*0.5f,1.0f);
        endText.text = "分拣正确\n" + Managers.level.rightPack + "/" + Managers.pack.packageCount;
    }
}
