using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color DefaultColor;
    public Color SelectedColor;
    Renderer renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = DefaultColor;
    }

    public void SelectEntered()
    {
        renderer.material.color = SelectedColor;
    }

    public void SelextExited()
    {
        renderer.material.color = DefaultColor;
    }

}
