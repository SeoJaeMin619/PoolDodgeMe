using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance;

    public int currentStage = 1; // ���� ��������
    public int currentLevel = 1; // ���� ����
    public float levelDuration = 60.0f; // ���� ���� �ð�
    private float timeElapsed = 0.0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        UpdateLevel();
    }

    void UpdateLevel()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= levelDuration)
        {
            // 60�ʰ� ������ ������ 1 ������Ű�� ���� ������ �ʿ��� ������ �����մϴ�.
            currentLevel++;
            timeElapsed = 0.0f;
        }
    }

    // �ٸ� ��ũ��Ʈ���� StageManager.Instance.currentStage�� StageManager.Instance.currentLevel�� ���� ���������� ������ ������ �� �ֽ��ϴ�.
}
