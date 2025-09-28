using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Singleton

    public static UIManager Instance { get; private set; }

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

    [Header("Screens")]
    public GameObject pauseScreen;
    public GameObject gameOverScreen;

    [Header("ASync Loader")]
    [SerializeField] private ASyncLoader asyncLoader;

    public void OnPauseButtonClicked()
    {
        GameManager.Instance.SetGameState(GameManager.GameState.Paused);
    }

    public void OnResumeGameClicked()
    {
        GameManager.Instance.SetGameState(GameManager.GameState.Gameplay);
    }

    public void OnMainMenuButtonClicked()
    {
        asyncLoader.LoadLevelBtn("MainMenu");
        GameManager.Instance.SetGameState(GameManager.GameState.MainMenu);
    }

    public void OnRestartButtonClicked()
    {
        asyncLoader.LoadLevelBtn("GameScene");
        GameManager.Instance.SetGameState(GameManager.GameState.Gameplay);
        ScoreManager.Instance.ResetScores();
        gameOverScreen.SetActive(false);
    }

    public void PauseGame()
    {
        pauseScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
    }
}
