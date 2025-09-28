using UnityEngine;

public class AimController : MonoBehaviour
{
    [SerializeField] private Transform aimTarget;
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private float aimSpeed = 6f;

    private void Start()
    {
        initialPosition = aimTarget.position;
    }

    public void MoveAim(Vector3 input)
    {
        aimTarget.Translate(input * aimSpeed * Time.deltaTime);
    }

    public Vector3 TargetPosition => aimTarget.position;

    public void ResetAim()
    {
        aimTarget.position = initialPosition;
    }
}
