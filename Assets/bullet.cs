using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Transform deadPool;
    // Start is called before the first frame update
    void Start()
    {
        deadPool = GameObject.Find("DeadPool").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * 5 * Time.deltaTime;
        //销毁子弹
        if(transform.position.x >= 7)
        {
            gameObject.SetActive(false);
            transform.SetParent(deadPool);
        }
    }
}
