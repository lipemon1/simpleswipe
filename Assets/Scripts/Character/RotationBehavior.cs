using UnityEngine;

public class RotationBehavior : MonoBehaviour
{
    [SerializeField] private float m_RotationSpeed = 1f;
    void Start()
    {
        TouchInputBase.OnSwipeRotation += OnSwipeRotation;
    }

    private void OnSwipeRotation(float delta)
    {
        delta *= -1f;

        Vector3 currentDegree = this.transform.rotation.eulerAngles;
        Vector3 to = new Vector3(currentDegree.x, currentDegree.y + delta, currentDegree.z);

        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime * m_RotationSpeed);
    }
}
