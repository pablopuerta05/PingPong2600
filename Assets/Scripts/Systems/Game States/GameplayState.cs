using UnityEngine;

public class GameplayState : IState
{
    [HideInInspector] public string Name { get => "Gameplay State"; }
    public GameManager.GameState gameState { get => GameManager.GameState.Gameplay; }
    private GameManager gameManager;

    // Constructor de la clase
    public GameplayState(GameManager gm)
    {
        gameManager = gm;
    }

    public void Enter()
    {
        Time.timeScale = 1.0f;
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        Pause();
    }

    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameManager.SetGameState(GameManager.GameState.Paused);

            if (gameManager.currentState.gameState == GameManager.GameState.Paused)
            {
                Debug.Log("El juego está en pausa.");
            }
        }
    }
}
