using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.parent.GetComponent<AudioSource>().Play() ;
        transform.DOLocalMove(new Vector3(-11.02f, 4.77f, 0), 0.5f).OnComplete(EndMove);

    }
     private void EndMove()
    {
        //增加阳光
        GameData.sunPoint += 25;
        //销毁太阳
        Destroy(gameObject); 
    }
}
