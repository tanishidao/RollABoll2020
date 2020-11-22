using UnityEngine;

public class DisturbanceBullet : MonoBehaviour
{
    [SerializeField] private float m_fireTime = 5f;
    private GameObject m_sphere = null;
    private BulletPool m_bulletPool = null;
    private float m_bulletSpeed = 5f;

    private void Start()
    {
        m_sphere = GameObject.FindGameObjectWithTag("Player");
        var bulletRoot = GameObject.Find("SphereBulletRoot");
        m_bulletPool = bulletRoot.GetComponent<BulletPool>();
    }

    private void Update()
    {
        if (m_sphere == null)
        {
            return;
        }

        m_fireTime -= Time.deltaTime;

        if (m_fireTime < 0)
        {
            var bullet = m_bulletPool.GetBullet(transform);
            bullet.transform.position = transform.position;
            transform.LookAt(m_sphere.transform);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * m_bulletSpeed;
            m_fireTime = 5f;
        }
    }
}

