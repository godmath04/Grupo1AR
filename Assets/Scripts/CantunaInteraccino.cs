using UnityEngine;

public class CantuñaInteraccion : MonoBehaviour
{
    private bool desaparecido = false;

    void OnMouseDown()
    {
        if (desaparecido) return;

        desaparecido = true;

        // Efecto de desaparición simple
        gameObject.SetActive(false); // O puedes animar con escala o partículas
        Debug.Log("Cantuña ha sido liberado del pacto");
    }
}
