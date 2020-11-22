using UnityEngine;

public class SphereAttack : MonoBehaviour
{
    [SerializeField] private BulletPool m_bulletPool = null;
    [SerializeField] private GameObject m_Sphere = null;
    [SerializeField] private float m_bulletSpeed = 30f;
    private bool m_isFire = false;
        
        private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_isFire = true;
        }
    }

    private void Update()
    {
        var diffPos = transform.position - m_Sphere.transform.position;
        if (diffPos.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(-diffPos);
        }
        transform.position = m_Sphere.transform.position;

        if (m_isFire)
        {
            var bullet = m_bulletPool.GetBullet(transform);
            if (bullet == null)
            {
                return;
            }
            bullet.transform.position = transform.position + transform.forward;
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * m_bulletSpeed;
            m_isFire = false;
        }
    }



}
