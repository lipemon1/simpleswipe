using UnityEngine;

public class PickupBehavior : BaseAnimationBehavior, IAnimationBehavior
{
    [SerializeField] private string m_PickupAnim;
    
    public void ExecuteBehavior(Animator animator, ICharacterController simpleSampleCharacterControl)
    {
        animator.SetTrigger(m_PickupAnim);
    }

    public void ResetBehavior(Animator animator) {}
    public override IAnimationBehavior GetAnimationBehavior()
    {
        return this;
    }
}
