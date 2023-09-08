using UnityEngine;

public class ItemCollisionHandler : MonoBehaviour
{
    private bool hasCollided = false; // �� �� �浹�ߴ��� ���θ� ��Ÿ���� �÷���

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasCollided && collision.CompareTag("Player"))
        {
            // �÷��̾�� �������� �浹�ϸ� ȭ�� �� ��� ���� �߻�ü�� �����ϴ� ������ �߰��մϴ�.
            Debug.Log("�÷��̾�� ������ �浹!");
            DestroyAllProjectiles();

            // �������� �ı��ϰ�, �ٽ� �浹���� �ʵ��� �÷��׸� �����մϴ�.
            Destroy(gameObject);
            hasCollided = true;
        }
    }

    private void DestroyAllProjectiles()
    {
        // ȭ�� �� ��� �߻�ü�� ã�Ƽ� �����ϴ� ������ �߰��մϴ�.
        Projectile[] projectiles = FindObjectsOfType<Projectile>();
        foreach (Projectile projectile in projectiles)
        {
            Destroy(projectile.gameObject);
        }
    }
}
