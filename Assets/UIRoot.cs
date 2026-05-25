 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIRoot : MonoBehaviour
{
    public Text sunPointTxt;
    public Image currentPlant;
    // Start is called before the first frame update
    void Start()
    {
        currentPlant.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        sunPointTxt.text = GameData.sunPoint.ToString();
        currentPlant.transform.position = Input.mousePosition;//让currentPlant跟随鼠标移动
        //如果等于-1，图片隐藏
        if(GameData.currentPlantId == -1)
        {
            currentPlant.gameObject.SetActive(false);
        }
        if(Input.GetMouseButtonDown(1))
        {
            GameData.currentPlantId = -1;
        }
    }
}
