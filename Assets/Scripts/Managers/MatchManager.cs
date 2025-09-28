using UnityEngine;

public class MatchManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Ball ball;
    [SerializeField] private Transform ballStartPosition;

    [SerializeField] private Transform player;
    [SerializeField] private Transform playerStartPosition;

    [SerializeField] private Transform bot;
    [SerializeField] private Transform botStartPosition;

    [Header("Serve Positions")]
    [SerializeField] private Transform playerServePosition;
    [SerializeField] private Transform botServePosition;

    [Header("Delay")]
    [SerializeField] private float pointResetDelay = 2f;

    private bool playerServes = true; // quién arranca sacando

    private void Start()
    {
        ResetPoint();
    }

    public void ResetPoint()
    {
        // Reset pelota
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        ball.hitter = Hitter.None;

        // Reset posiciones de jugadores
        player.position = playerStartPosition.position;
        bot.position = botStartPosition.position;

        // Poner pelota en el servidor
        if (playerServes)
        {
            ball.transform.position = playerServePosition.position;
        }
        else
        {
            ball.transform.position = botServePosition.position;
        }

        // Alternar servidor para el siguiente punto
        playerServes = !playerServes;

        // Reset Aim del jugador
        AimController aim = player.GetComponentInChildren<AimController>();
        if (aim != null) aim.ResetAim();
    }
}
