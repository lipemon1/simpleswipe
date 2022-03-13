using UnityEngine;

public abstract class TouchInputBase : MonoBehaviour
{
    [SerializeField]
    protected float m_DeltaTreshold;
    
    private float m_NewRotationDelta;
    private float m_SwipeMultiplier = 1f;
    
    public delegate void OnSwipeRotationDelegate(float delta);
    public static OnSwipeRotationDelegate OnSwipeRotation;
    
    protected abstract float GetLastRotationDelta();

    private void Update()
    {
        m_NewRotationDelta = GetLastRotationDelta();
        if (Mathf.Abs(m_NewRotationDelta) > m_DeltaTreshold)
        {
            DispatchNewRotationDelta(m_NewRotationDelta);
        }
    }

    private void DispatchNewRotationDelta(float newDelta)
    {
        OnSwipeRotation?.Invoke(newDelta);
    }
}
