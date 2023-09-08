using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Enemy ������
    public float initialDelay = 1.0f; // �ʱ� ���� �ð� (5��)
    public float spawnInterval = 60.0f; //  ���� ���� (10�ʷ� ����)

    private float spawnYMin = -3f; // Y ��ǥ �ּҰ�
    private float spawnYMax = 3f; // Y ��ǥ �ִ밪

    private void Start()
    {
        // �ʱ� ���� �ð� ���ĺ��� ���� �ֱ⸶�� �������� �����ϴ� �Լ� ȣ��
        InvokeRepeating("SpawnEnemies", initialDelay, spawnInterval);
    }

    private void SpawnEnemies()
    {
        // �����ϰ� ������ ���� �����մϴ� (0�� X ��, 1�� Y ��)
        int randomAxis = Random.Range(0, 2);

        // ������ ��ġ�� �ʱⰪ�� �����մϴ�.
        float spawnX = 0f;
        float spawnY = 0f;

        // ���� �����Ͽ� �ش� ���� ���� �����ϰ� �����մϴ�.
        if (randomAxis == 0)
        {
            // X ���� ������ ���
            spawnX = Random.Range(-8f, 8f);
            spawnY = (Random.Range(0, 2) == 0) ? -3f : 3f; // -3 �Ǵ� 3 �߿��� ���� ����
        }
        else
        {
            // Y ���� ������ ���
            spawnX = (Random.Range(0, 2) == 0) ? -8f : 8f; // -8 �Ǵ� 8 �߿��� ���� ����
            spawnY = Random.Range(-3f, 3f);
        }

        // ���� ������ ��ġ�� �����մϴ�.
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);

        // Enemy�� �����մϴ�.
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
