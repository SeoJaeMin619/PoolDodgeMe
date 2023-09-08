using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Enemy �̵� �ӵ�
    private Vector3 moveDirection; // �̵� ����
    private float minX = -8.0f; // ȭ�� ���� ���
    private float maxX = 8.0f; // ȭ�� ������ ���
    private float minY = -3.0f; // ȭ�� �Ʒ��� ���
    private float maxY = 3.0f; // ȭ�� ���� ���

    private void Start()
    {
        // �ʱ� �̵� ���� ����
        SetRandomMoveDirection();
    }

    private void Update()
    {
        MoveEnemy();
        CheckScreenBounds();
    }

    private void MoveEnemy()
    {
        // Enemy�� ���� �̵� ����� �ӵ��� ����Ͽ� �̵��մϴ�.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void SetRandomMoveDirection()
    {
        // ������ ���� ���͸� �����մϴ�.
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        moveDirection = new Vector3(randomX, randomY, 0).normalized;
    }

    public void SetMoveDirection(Vector3 direction)
    {
        moveDirection = direction.normalized;
    }

    private void CheckScreenBounds()
    {
        // ȭ�� ��迡 �����ϸ� ������ �̵� ������ �ٽ� �����մϴ�.
        Vector3 position = transform.position;

        if (position.x < minX || position.x > maxX || position.y < minY || position.y > maxY)
        {
            SetRandomMoveDirection();
        }
    }
}
