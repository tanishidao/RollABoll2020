using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpColorChange : MonoBehaviour
{
    private PickUpDisposition m_pickUpDisposition = null;

    private Color SpeedUpColor = Color.red;
    private Color SpeedDownColor = Color.blue;
    private Color QTEcolor = Color.magenta;

    void Start()
    {
        m_pickUpDisposition = GetComponent<PickUpDisposition>();
        
        var mat = GetComponent<MeshRenderer>().material;
       
        switch (m_pickUpDisposition.m_pickUpDisposition)
        {
            case PickUpDisposition.PublicPickUpDisposition.SpeedUp:
                mat.color = SpeedUpColor;
                break;
            case PickUpDisposition.PublicPickUpDisposition.SpeedDown:
                mat.color = SpeedDownColor;
                break;
            case PickUpDisposition.PublicPickUpDisposition.QTE:
                mat.color = QTEcolor;
                break;
        }
    }
}
