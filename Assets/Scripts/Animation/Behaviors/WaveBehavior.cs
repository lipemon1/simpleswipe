using UnityEngine;

public class WaveBehavior : BaseAnimationBehavior, IAnimationBehavior
{
    [SerializeField] private string m_WaveAnim;
    public void ExecuteBehavior(Animator animator, ICharacterController simpleSampleCharacterControl)
    {
        animator.SetTrigger(m_WaveAnim);
    }

    public void ResetBehavior(Animator animator) {}
    public override IAnimationBehavior GetAnimationBehavior()
    {
        return this;
    }
}
