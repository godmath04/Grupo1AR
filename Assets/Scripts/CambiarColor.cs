using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        _renderer.material.color = Random.ColorHSV();
    }
}
