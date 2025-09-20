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
        
    }
}
