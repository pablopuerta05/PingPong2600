using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    #region Singleton

    public static ScoreManager Instance { get; private set; }

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

    #endregion

    [SerializeField] private int playerScore;
    [SerializeField] private int botScore;

    [SerializeField] TextMeshProUGUI playerScoreText;
    [SerializeField] TextMeshProUGUI botScoreText;

    public void UpdateScores()
    {
        playerScoreText.text = playerScore.ToString();
        botScoreText.text = botScore.ToString();
    }

    private void Update()
    {
        if (!GameManager.Instance.isGameOver)
        {
            CheckSetWinner();
        }
    }

    public void AddPlayerScore(int amount)
    {
        playerScore += amount;
    }

    public void AddBotScore(int amount)
    {
        botScore += amount;
    }

    public void CheckSetWinner()
    {
        if (playerScore == 11 || botScore == 11)
        {
            UIManager.Instance.gameOverScreen.SetActive(true);
            GameManager.Instance.SetGameState(GameManager.GameState.GameOver);
        }
    }

    public void ResetScores()
    {
        playerScore = 0;
        botScore = 0;
        UpdateScores();
    }
}
