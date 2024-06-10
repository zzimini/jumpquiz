using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score;
    public PortalManager portalManager; // ���� �Ŵ��� ���� �߰�

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();

        if (score >= 100)
        {
            portalManager.CreatePortal();
        }
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
        BlockCollision.ResetAllBlocks(); // ��� ����� ���� ȹ�� ���� �ʱ�ȭ
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
