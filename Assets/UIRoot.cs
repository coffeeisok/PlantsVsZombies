using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIRoot : MonoBehaviour
{
    public Text sunPointTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sunPointTxt.text = GameData.sunPoint.ToString();
    }
}
