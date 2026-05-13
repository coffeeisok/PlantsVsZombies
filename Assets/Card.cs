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

    //定义计时器
    public float timer;
    //定义CD时间
    public float CD;
    public int needSun;
    // Start is called before the first frame update
    void Start()
    {
        state = CardState.CD;
        //添加按钮点击事件
        ready.onClick.AddListener(OnclickedReady);
        
    }
    private void OnclickedReady()
    {
        print("点击了这个按钮");
        //如果当前状态是阳光充足
        if (state == CardState.Ready)
        {
            //状态切换到CD
            state = CardState.CD;
            //阳光扣除
            GameData.sunPoint -= needSun;
            //计时器重置
            timer = 0;
        }
        //
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
                //计时器开始计时
                timer += Time.deltaTime;
                cdImg.fillAmount = (CD - timer) / CD;
                //当即时期时间大于等于CD时间
                if (timer >= CD)
                {
                    //状态切换到阳光充足
                    state = CardState.NoSun;
                    //计时器重置
                    timer = 0;
                }
                break;
            case CardState.NoSun:
                ready.gameObject.SetActive(true);
                NoSun.gameObject.SetActive(true);
                cdImg.gameObject.SetActive(false);
                //如果阳光数大于等于这棵植物需要的阳光数
                if (needSun <= GameData.sunPoint)
                {
                    //状态切换到阳光充足
                    state = CardState.Ready;
                }
                break;
            case CardState.Ready:
                ready.gameObject.SetActive(true);
                NoSun.gameObject.SetActive(false);
                cdImg.gameObject.SetActive(false);
                break;
        }
    }
}
