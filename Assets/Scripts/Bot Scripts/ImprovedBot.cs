using UnityEngine;

public class ImprovedBot : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float speed = 40f;
    [SerializeField] Transform ball;
    [SerializeField] Transform[] targets;
    [SerializeField] ShotSO[] availableShots;

    Animator animator;
    IMovement movement;
    IShotSelector shotSelector;
    IAnimationHandler animationHandler;

    void Start()
    {
        animator = GetComponent<Animator>();

        movement = new HorizontalMovement();
        shotSelector = new RandomShotSelector(availableShots);
        animationHandler = new BotAnimationHandler();
    }

    void Update()
    {
        movement.MoveTowardsBall(transform, ball, speed);
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
