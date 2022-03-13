using UnityEngine;

public class RunningBehavior : BaseAnimationBehavior, IAnimationBehavior
{
    private static readonly int MoveSpeed = Animator.StringToHash("MoveSpeed");

    public void ExecuteBehavior(Animator animator, ICharacterController simpleSampleCharacterControl)
    {
        animator.SetFloat(MoveSpeed, 1f);
    }

    public void ResetBehavior(Animator animator)
    {
        animator.SetFloat(MoveSpeed, 0f);
    }

    public override IAnimationBehavior GetAnimationBehavior()
    {
        return this;
    }
}
