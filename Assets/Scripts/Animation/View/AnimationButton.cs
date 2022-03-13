using UnityEngine;
using UnityEngine.UI;

public class AnimationButton : MonoBehaviour
{
    [SerializeField] private string m_ButtonLabel;
    [SerializeField] private Button m_AnimationButton;
    [SerializeField] private Text m_AnimationButtonText;
    [SerializeField] private BaseAnimationBehavior m_baseAnimationBehavior;

    private void Start()
    {
        m_AnimationButtonText.text = m_ButtonLabel;
        m_AnimationButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        AnimController.Instance.ExecuteAnimation(m_baseAnimationBehavior.GetAnimationBehavior());
    }
}
