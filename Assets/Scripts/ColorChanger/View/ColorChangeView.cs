using System;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeView : MonoBehaviour
{
    [SerializeField] private Button m_PlayerColorChangeButton;
    [SerializeField] private Button m_BackgroundColorChangeButton;
    [SerializeField] private Button m_ResetColorButton;

    private void Awake()
    {
        m_PlayerColorChangeButton.onClick.AddListener(OnPlayerChangeColorClicked);
        m_BackgroundColorChangeButton.onClick.AddListener(OnBackgroundChangeColorClicked);
        m_ResetColorButton.onClick.AddListener(OnResetColorClicked);
    }

    private void OnResetColorClicked()
    {
        ColorChangerController.Instance.ResetColors();
    }

    private void OnBackgroundChangeColorClicked()
    {
        ColorChangerController.Instance.ChangeBackgroundColor();
    }

    private void OnPlayerChangeColorClicked()
    {
        ColorChangerController.Instance.ChangePlayerColor();
    }
}
