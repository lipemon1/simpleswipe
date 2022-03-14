using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChangerController : MonoBehaviour
{
    public static ColorChangerController Instance { get; set; }

    [SerializeField] private Material m_PlayerMaterial;

    private Camera m_Camera;
    private Color m_PlayerInitialColor;
    private Color m_BackgroundInitialColor;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
        
        m_Camera = Camera.main;

        m_BackgroundInitialColor = m_Camera.backgroundColor;
        m_PlayerInitialColor = m_PlayerMaterial.GetColor("_Color");
    }

    public void ChangePlayerColor()
    {
        ChangePlayerMaterialColor(GetRandomColor());
    }

    public void ChangeBackgroundColor()
    {
        m_Camera.backgroundColor = GetRandomColor();
    }

    public void ResetColors()
    {
        m_Camera.backgroundColor = m_BackgroundInitialColor;
        ChangePlayerMaterialColor(m_PlayerInitialColor);
    }

    private void ChangePlayerMaterialColor(Color color)
    {
        m_PlayerMaterial.SetColor("_Color", color);
    }

    private Color GetRandomColor()
    {
        float r = Random.Range(0f, 255f);
        float g = Random.Range(0f, 255f);
        float b = Random.Range(0f, 255f);
        float a = 1f;
        return new Color(r/255, g/255, b/255, a);
    }
}
