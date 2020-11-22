using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotater : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform  m_pickUpTransform = null;
   private void Start()
    {
        m_pickUpTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        m_pickUpTransform.Rotate(0, 1, 0,Space.Self);
    }
}
