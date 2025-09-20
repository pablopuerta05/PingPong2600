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
        throw new System.NotImplementedException();
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
