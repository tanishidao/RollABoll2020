using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Start is called before the first frame update
   
    
        ///<summary>
        ///球のRigidody
        /// </summary>
    private Rigidbody m_sphereRigiBody;
    ///<summary>
    ///keybordのインプットを代入するVector3
    ///</summary>
    private Vector3 m_inputAxis = Vector3.zero;

    /// <summary>
    /// 球加速度
    /// </summary>
    public float ShpereAcceleration = 1.0f;
   
    void Start()
    {
        m_sphereRigiBody = this.GetComponent<Rigidbody>();
            }
    private void FixedUpdate()
    {
        m_inputAxis.Set(Input.GetAxis("Horizontal") * ShpereAcceleration, 0, Input.GetAxis("Vertical"));
        m_sphereRigiBody.AddForce(m_inputAxis);
    }


    
        
}
