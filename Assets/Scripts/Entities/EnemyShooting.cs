using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // �߻�ü ������
    public Transform shootingPoint; // �߻� ��ġ
    public float shootInterval = 2.0f; // �߻� �ֱ�
    public float projectileSpeed = 10.0f; // �߻�ü �ӵ�
    private Transform player; // Player ������Ʈ
    //private float timeSinceLastShot = 0.0f;

    private void Start()
    {
        // Player ������Ʈ�� ã�� �����մϴ�.
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // ���� �ֱ�� ShootAtPlayer �Լ��� ȣ���մϴ�.
        InvokeRepeating("ShootAtPlayer", 0, shootInterval);
    }

    private void ShootAtPlayer()
    {
        if (player != null)
        {
            // Player�� Enemy ������ ���� ���͸� ����մϴ�.
            Vector3 directionToPlayer = (player.position - shootingPoint.position).normalized;

            // �߻�ü�� �����ϰ� �ʱ� �ӵ��� �����մϴ�.
            GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.velocity = directionToPlayer * projectileSpeed;
        }
    }
}

