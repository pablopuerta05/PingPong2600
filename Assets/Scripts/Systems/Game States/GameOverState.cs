using UnityEngine;

public class GameOverState : IState
{
    [HideInInspector] public string Name { get => "GameOver State"; }
    public GameManager.GameState gameState { get => GameManager.GameState.GameOver; }
    private GameManager gameManager;

    // Constructor de la clase
    public GameOverState(GameManager gm)
    {
        gameManager = gm;
    }

    public void Enter()
    {
        gameManager.isGameOver = true;
    }

    public void Exit()
    {
        gameManager.isGameOver = false;
    }

    public void Update()
    {

    }
}
