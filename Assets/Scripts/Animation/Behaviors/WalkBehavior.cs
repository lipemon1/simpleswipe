using UnityEngine;

public class WalkBehavior : BaseAnimationBehavior, IAnimationBehavior
{
    private static readonly int MoveSpeed = Animator.StringToHash("MoveSpeed");

    public void ExecuteBehavior(Animator animator, ICharacterController simpleSampleCharacterControl)
    {
        animator.SetFloat(MoveSpeed, 0.5f);
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
