using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
植物卡片功能脚本
三种状态：
1. CD
2. 阳光充足
3. 阳光不足 
*/

public class Card : MonoBehaviour
{
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
                break;
            case CardState.NoSun:
                break;
            case CardState.ready:
                break;
        }
    }
}
