using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisposition : MonoBehaviour
{
    public enum PublicPickUpDisposition
    {
        None = 0,   //何もない
        SpeedUp,   //加速
        SpeedDown,  // 減速
        QTE,　　//QTE始まる
        DispositionMax //性質数のMAX

    }
    public PublicPickUpDisposition m_pickUpDisposition = PublicPickUpDisposition.None;

    private void Awake()
    {
        var ranbdomDisposition = 0;
       
        ranbdomDisposition = Random.Range((int)PublicPickUpDisposition.None, (int)PublicPickUpDisposition.DispositionMax);
       
        m_pickUpDisposition = (PublicPickUpDisposition)ranbdomDisposition;

    }
}
