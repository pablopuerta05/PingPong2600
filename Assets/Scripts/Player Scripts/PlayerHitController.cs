using UnityEngine;

public class PlayerHitController : MonoBehaviour
{
    [Header("Hit Settings")]
    [SerializeField] private float hitForce = 10f;
    [SerializeField] private float upwardForce = 2f;
    [SerializeField] private KeyCode hitKey = KeyCode.Space; // un solo botón

    [SerializeField] private AimController aim;
    [SerializeField] private AnimationHandler animationHandler;

    private Rigidbody ballRigidbody;
    private Collider ballCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballCollider = other;
            ballRigidbody = other.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballCollider = null;
            ballRigidbody = null;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(hitKey) && ballRigidbody != null)
        {
            ExecuteShot(ballCollider, aim.TargetPosition, transform);
            Vector3 dir = ballCollider.transform.position - transform.position;
            animationHandler.PlayShot(dir);
            //aim.ResetAim();
        }
    }

    public void ExecuteShot(Collider ballCollider, Vector3 aimTarget, Transform playerTransform)
    {
        Rigidbody rb = ballCollider.GetComponent<Rigidbody>();
        Vector3 dir = aimTarget - playerTransform.position;

        rb.velocity = dir.normalized * hitForce + new Vector3(0, upwardForce, 0);

        Ball ballScript = ballCollider.GetComponent<Ball>();
        ballScript.hitter = Hitter.Player;
    }
}
