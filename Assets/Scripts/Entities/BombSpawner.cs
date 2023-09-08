using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemBombPrefab; // ��ź ������ ������
    public float initialDelay = 5.0f; // �ʱ� ���� �ð� (5��)
    public float spawnInterval = 5.0f; // ������ ���� ���� (5�ʷ� ����)
    private Camera mainCamera; // ���� ī�޶� ����

    private void Start()
    {
        // ���� ī�޶� ã�� �����մϴ�.
        mainCamera = Camera.main;

        // �ʱ� ���� �ð� �ĺ��� ���� �ֱ⸶�� �������� �����ϴ� �Լ� ȣ��
        InvokeRepeating("SpawnItems", initialDelay, spawnInterval);
    }

    private void SpawnItems()
    {
        // x�� y ��ǥ�� �����ϰ� �����մϴ�.
        float randomX = Random.Range(-8f, 8f);
        float randomY = Random.Range(-3f, 3f);

        // �������� �����մϴ�.
        Vector3 spawnPosition = new Vector3(randomX, 0, randomY);
        GameObject itemBomb = Instantiate(itemBombPrefab, spawnPosition, Quaternion.identity);

        // �����۰� �÷��̾��� �浹�� �����ϱ� ���� Collider2D ������Ʈ�� �߰��մϴ�.
        Collider2D itemCollider = itemBomb.GetComponent<Collider2D>();
        if (itemCollider != null)
        {
            // �����۰� �÷��̾��� �浹�� �����ϴ� ��ũ��Ʈ�� �߰��մϴ�.
            itemCollider.isTrigger = true;
            itemCollider.gameObject.AddComponent<ItemCollisionHandler>();
        }
    }
}
