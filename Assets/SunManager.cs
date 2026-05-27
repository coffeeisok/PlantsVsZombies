 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//随机掉落阳光
//CD随机
//生成位置随机——y:5.67,x:-11.02~0.92
//终点位置随机——x:跟随启示位置固定不变,y:-4.19~3.18
public class SunManager : MonoBehaviour
{
    public float timer;
    public float CD;
    public GameObject sunObj;
    // Start is called before the first frame update
    void Start()
    {
        CD = Random.Range(5, 9);

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= CD)
        {
            GameObject obj = Instantiate(sunObj);
            obj.transform.SetParent(transform);
            //设置生成位置
            obj.transform.localPosition = new Vector3(Random.Range(-11.02f, 0.92f), 5.67f, 0);
            //落到终点去
            
            timer = 0;//重置CD
            CD = Random.Range(5, 9);
            //设置终点位置


        }
    }
}
