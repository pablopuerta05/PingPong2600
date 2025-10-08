using UnityEngine;

public class ImprovedBot : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float[] speed;
    [SerializeField] private float actualSpeed;
    private float timer;
    [SerializeField] private float delay;
    [SerializeField] Transform ball;
    [SerializeField] Transform[] targets;
    [SerializeField] ShotSO[] availableShots;

    Animator animator;
    IMovement movement;
    IShotSelector shotSelector;
    IAnimationHandler animationHandler;

    void Start()
    {
        actualSpeed = speed[Random.Range(0, speed.Length)];

        animator = GetComponent<Animator>();

        movement = new HorizontalMovement();
        shotSelector = new RandomShotSelector(availableShots);
        animationHandler = new BotAnimationHandler();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            actualSpeed = speed[Random.Range(0, speed.Length)];
            timer = 0;
        }

        movement.MoveTowardsBall(transform, ball, actualSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ball")) return;

        ShotSO shot = shotSelector.PickShot();
        Vector3 dir = PickTarget() - transform.position;

        shot.ApplyForce(other.GetComponent<Rigidbody>(), dir);

        Vector3 ballDir = ball.position - transform.position;
        animationHandler.PlayAnimation(animator, ballDir);

        ball.GetComponent<Ball>().hitter = Hitter.Bot;
    }

    private Vector3 PickTarget()
    {
        int r = Random.Range(0, targets.Length);
        return targets[r].position;
    }
}
