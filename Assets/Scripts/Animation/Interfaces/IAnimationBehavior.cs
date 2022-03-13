using UnityEngine;

public interface IAnimationBehavior
{
    void ExecuteBehavior(Animator animator, ICharacterController simpleSampleCharacterControl);
    void ResetBehavior(Animator animator);
}
