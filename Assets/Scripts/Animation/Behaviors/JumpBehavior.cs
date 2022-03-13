using UnityEngine;

public class JumpBehavior : BaseAnimationBehavior, IAnimationBehavior
{
    public void ExecuteBehavior(Animator animator, ICharacterController simpleSampleCharacterControl)
    {
        simpleSampleCharacterControl.StartJump();
    }

    public void ResetBehavior(Animator animator) {}

    public override IAnimationBehavior GetAnimationBehavior()
    {
        return this;
    }
}
