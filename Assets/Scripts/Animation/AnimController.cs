using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public static AnimController Instance;
    
    [SerializeField]
    private Animator m_animator;
    [SerializeField]
    private SimpleSampleCharacterControl m_simpleSampleCharacterControl;

    private readonly List<IAnimationBehavior> m_animationBehaviors = new List<IAnimationBehavior>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
        
        if (m_animator == null)
            m_animator = this.gameObject.GetComponent<Animator>();
        
        if(m_simpleSampleCharacterControl == null)
            m_simpleSampleCharacterControl = this.gameObject.GetComponent<SimpleSampleCharacterControl>();
    }

    public void ExecuteAnimation(IAnimationBehavior animationBehavior)
    {
        HoldAnimationBehavior(animationBehavior);
        ResetOtherBehaviors();
        
        animationBehavior.ExecuteBehavior(m_animator, m_simpleSampleCharacterControl);
    }

    private void HoldAnimationBehavior(IAnimationBehavior animationBehavior)
    {
        if (!m_animationBehaviors.Contains(animationBehavior))
        {
            m_animationBehaviors.Add(animationBehavior);
        }
    }

    private void ResetOtherBehaviors()
    {
        foreach (IAnimationBehavior animationBehavior in m_animationBehaviors)
        {
            animationBehavior.ResetBehavior(m_animator);
        }
    }
}
