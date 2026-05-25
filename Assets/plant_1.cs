using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_1 : MonoBehaviour
{
    public float timer;
    public float CD;
    public GameObject peaBulletObj;
    public int count = 0;
    public Transform livePool;  
    public Transform deadPool;
    // Start is called before the first frame update
    void Start()
    {
        //获取LivePool和DeadPool的transform
        livePool = GameObject.Find("LivePool").transform;
        deadPool = GameObject.Find("DeadPool").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= CD)
        {
            print("生成子弹");
            //生成子弹                    
            GameObject obj;
            if(deadPool.childCount != 0)//如果死池中有子弹
            {
                obj = deadPool.GetChild(0).gameObject;
                
            }
            else
            {
                obj = Instantiate(peaBulletObj);
                count++; 
            }
            obj.transform.position = transform.position + new Vector3(0, 0.5f, 0);
            obj.transform.SetParent(livePool);
            obj.SetActive(true);
            timer = 0;
        }

    }
}
