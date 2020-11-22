using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderReceiveAction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject m_thisObject = null;

    public bool IsTriggerEnter = false;

    public int DeadCount = 0;

    public int DamageCount = 0;

    private void Awake()
    {

        m_thisObject = this.gameObject;
    }
    /// <summary>
    /// 当たったら自分のgameObject消す
    /// </summary>
    ///<param name="other"></param>
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)

    {
        DamageCount++;
        if (DamageCount >= DeadCount)
        {
            StartCoroutine(TriggerEnter());
        }


    }
    ///<summary>
    ///1faramewaite
    ///</summary>>
    ///<returns></returns>>

    IEnumerator TriggerEnter()
    {
        IsTriggerEnter = true;
        yield return new WaitForEndOfFrame();
        m_thisObject.SetActive(false);
    }
}
