using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
植物卡片功能脚本
三种状态：
1. CD
2. 阳光充足
3. 阳光不足 
*/
public enum CardState
{
    CD,
    NoSun,
    Ready
}
public class Card : MonoBehaviour
{
    public CardState state;
    // 定义这三张图片
    public Button ready;
    public GameObject NoSun;
    
    public Image cdImg;

    // Start is called before the first frame update
    void Start()
    {
        state = CardState.CD;
        
    }

    // Update is called once per frame
    void Update()
    {
       switch (state)
        {
            case CardState.CD:
                ready.gameObject.SetActive(true);
                NoSun.gameObject.SetActive(true);
                cdImg.gameObject.SetActive(true);
                break;
            case CardState.NoSun:
                ready.gameObject.SetActive(true);
                NoSun.gameObject.SetActive(true);
                cdImg.gameObject.SetActive(false);
                break;
            case CardState.Ready:
                ready.gameObject.SetActive(true);
                NoSun.gameObject.SetActive(false);
                cdImg.gameObject.SetActive(false);
                break;
        }
    }
}
