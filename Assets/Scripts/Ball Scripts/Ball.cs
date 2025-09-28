using UnityEngine;

public enum Hitter
{
    None,
    Player,
    Bot
}

public class Ball : MonoBehaviour
{
    public Hitter hitter = Hitter.None;
    [SerializeField] private MatchManager matchManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OutPlayer") || collision.gameObject.CompareTag("OutBot"))
        {
            ResetGame();
        }
        else if (collision.gameObject.CompareTag("Net"))
        {
            switch (hitter)
            {
                case Hitter.Player:
                    ScoreManager.Instance.AddBotScore(1);
                    ScoreManager.Instance.UpdateScores();
                    matchManager.ResetPoint();
                    break;
                case Hitter.Bot:
                    ScoreManager.Instance.AddPlayerScore(1);
                    ScoreManager.Instance.UpdateScores();
                    matchManager.ResetPoint();
                    break;
                default:
                    Debug.LogWarning("Hitter no definido");
                    break;
            }
        }
    }

    void ResetGame()
    {
        switch (hitter)
        {
            case Hitter.Player:
                ScoreManager.Instance.AddPlayerScore(1);
                ScoreManager.Instance.UpdateScores();
                break;
            case Hitter.Bot:
                ScoreManager.Instance.AddBotScore(1);
                ScoreManager.Instance.UpdateScores();
                break;
            default:
                Debug.LogWarning("Hitter no definido");
                break;
        }

        matchManager.ResetPoint();
    }
}
