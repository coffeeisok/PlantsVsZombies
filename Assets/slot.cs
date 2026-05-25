using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    public List<Card> Cards;
    public bool isHavePlant = false;
    //定义一个数组，类型：Card
    private void OnMouseDown()
    {

        if (GameData.currentPlantId != -1 && !isHavePlant)
        {
            //加载对应植物
            GameObject go = Instantiate(Resources.Load<GameObject>("Plant/" + GameData.currentPlantId));
            //设置父节点
            go.transform.parent = transform;
            //设置本地位置
            go.transform.localPosition = Vector3.zero;
            
            //对应的卡片变为CD状态
            Cards[GameData.currentPlantId].state = CardState.CD;
            //减少阳光
            GameData.sunPoint -= Cards[GameData.currentPlantId].needSun;
            //控制当前slot不允许在种植
            isHavePlant = true;
    
            //把currentPlantId重置为-1
            GameData.currentPlantId = -1; 
        }
        
    }
}
