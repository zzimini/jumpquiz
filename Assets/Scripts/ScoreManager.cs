using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score;
    public PortalManager portalManager; // 포털 매니저 참조 추가

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
        BlockCollision.ResetAllBlocks(); // 모든 블록의 점수 획득 상태 초기화
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
