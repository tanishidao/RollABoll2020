using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpGaugeAutoPlacement : MonoBehaviour
{
    [SerializeField] private PickUpHPGauge m_pickUpHpGauge;

    [SerializeField] private PickUpAutoPlacement m_pickUpAutoPlacement;

    private Transform m_root = null;

    private Transform[] m_target = null;

    private bool m_placementComplete = false;
    private void Start()
    {
        m_root = GetComponent<Transform>();
        m_placementComplete = false;

    }
    private void Update()
    {
        if (m_pickUpAutoPlacement.PickupTransforms.Length == 12 && !m_placementComplete)
        {
            for (int i = 0; i < 12; i++)
            {
                var gauge = Instantiate(m_pickUpHpGauge, m_root);
                gauge.Target = m_pickUpAutoPlacement.PickupTransforms[i];
                gauge.ColliderReceiveAction = gauge.Target.GetComponent<ColliderReceiveAction>();
            }
            m_placementComplete = true;
        }


    }
}