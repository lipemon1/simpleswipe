using UnityEngine;

public class MouseInputBehavior : TouchInputBase
{
    [SerializeField]
    private float m_CurrentTouchPosition;
    [SerializeField]
    private float m_LastTouchPosition;
    [SerializeField]
    private float m_CurLastPositionDelta;
    
    private bool m_IsTouching;
    private bool m_IsSwiping;

    protected override float GetLastRotationDelta()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_IsTouching = true;
        }

        if (m_IsTouching)
        {
            if (Input.GetMouseButton(0))
            {
                m_LastTouchPosition = m_CurrentTouchPosition;
                m_CurrentTouchPosition = Input.mousePosition.x;
            }
        
            if (Input.GetMouseButtonUp(0))
            {
                m_IsTouching = false;
            }   
        }

        if (m_IsTouching)
        {
            m_CurLastPositionDelta = m_CurrentTouchPosition - m_LastTouchPosition;
            m_IsSwiping = m_CurLastPositionDelta > m_DeltaTreshold;

            if (m_IsSwiping)
            {
                return m_CurLastPositionDelta;   
            }
        }

        return 0f;
    }
}
