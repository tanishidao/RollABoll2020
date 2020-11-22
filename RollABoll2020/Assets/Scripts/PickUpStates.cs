﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpStates : MonoBehaviour
{
    [SerializeField] private ColliderReceiveAction m_colliderReceiveAction = null;

    [SerializeField] private ObjectStates m_objectStates = null;

    [SerializeField] private ObjectData m_pickUpData = null;
    private void Awake()
    {
        m_colliderReceiveAction = gameObject.GetComponent<ColliderReceiveAction>();

        foreach (var pickUpData in m_objectStates.ObjectStatusList)
        {
            if (pickUpData.Name.Equals("PickUp"))
            {
                m_pickUpData = pickUpData;
            }

        }
        m_colliderReceiveAction.DeadCount = m_pickUpData.Hp;
    }
    
}