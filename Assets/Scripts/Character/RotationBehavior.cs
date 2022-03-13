using UnityEngine;

public class RotationBehavior : MonoBehaviour
{
    void Start()
    {
        TouchInputBase.OnSwipeRotation += OnSwipeRotation;
    }

    private void OnSwipeRotation(float delta)
    {
        Debug.Log($"Rotate [{delta}]");
    }
}
