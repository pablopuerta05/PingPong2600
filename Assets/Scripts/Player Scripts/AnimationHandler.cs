using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void PlayServe()
    {
        animator.Play("serve");
    }

    public void PlayPrepareServe()
    {
        animator.Play("serve-prepare");
    }

    public void PlayShot(Vector3 ballDir)
    {
        if (ballDir.x >= 0)
            animator.Play("Forehand");
        else
            animator.Play("Backhand");
    }
}
