using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10.0f; // �߻�ü �ӵ�
    public float lifetime = 2.0f; // �߻�ü ���� (��: 2��)


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, lifetime);

    }

    // �߻�ü�� � ���ǿ��� �����Ǿ�� ������ �߰��� ���� �ֽ��ϴ�.
    // ���� ���, �浹�ϸ� �����ϴ� ������ �߰��� �� �ֽ��ϴ�.
}
