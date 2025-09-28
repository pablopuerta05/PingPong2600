using UnityEngine;

public class BotAnimationHandler : IAnimationHandler
{
    public void PlayAnimation(Animator animator, Vector3 ballDir)
    {
        if (ballDir.x >= 0)
            animator.Play("forehand");
        else
            animator.Play("backhand");
    }
}