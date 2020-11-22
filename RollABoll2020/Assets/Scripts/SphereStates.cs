using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereStates : MonoBehaviour
{
    [SerializeField] private ObjectStates m_objectStates = null;

    private ObjectData m_sphereData = null;
    public int SphereHp = 0;

    public bool GameOver = false;
    private void Awake()
    {
        foreach (var pickUpData in m_objectStates.ObjectStatusList)
        {
            if (pickUpData.Name.Equals("Sphere"))
           {
                m_sphereData = pickUpData;
                SphereHp = m_sphereData.Hp;
            }


        }
    }


    private void Update()
    {
        if (SphereHp <= 0)
        {
            GameOver = true;
            Debug.Log("ゲームオーバー");
        }
    }
}