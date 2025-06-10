using UnityEngine;

public class Cantu�aInteraccion : MonoBehaviour
{
    private bool desaparecido = false;

    void OnMouseDown()
    {
        if (desaparecido) return;

        desaparecido = true;

        // Efecto de desaparici�n simple
        gameObject.SetActive(false); // O puedes animar con escala o part�culas
        Debug.Log("Cantu�a ha sido liberado del pacto");
    }
}
