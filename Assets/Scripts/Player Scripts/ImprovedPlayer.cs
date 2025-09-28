using UnityEngine;

public class ImprovedPlayer : MonoBehaviour
{
    [SerializeField] private PlayerInputHandler inputHandler;
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private AimController aim;
    [SerializeField] private AnimationHandler animationHandler;
    [SerializeField] private PlayerHitController hitController;

    [SerializeField] private Transform ball;

    private void Update()
    {
        if (inputHandler.IsHitting)
        {
            aim.MoveAim(inputHandler.MoveVector);
        }
        else
        {
            movement.Move(inputHandler.MoveVector);
        }
    }
}
