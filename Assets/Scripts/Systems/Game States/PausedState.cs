using UnityEngine;

public class PausedState : IState
{
    [HideInInspector] public string Name { get => "Paused State"; }
    public GameManager.GameState gameState { get => GameManager.GameState.Paused; }
    private GameManager gameManager;

    // Constructor de la clase
    public PausedState(GameManager gm)
    {
        gameManager = gm;
    }

    public void Enter()
    {
        Time.timeScale = 0f;
    }

    public void Exit()
    {
        Time.timeScale = 1f;
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }
}
