using UnityEngine;
using UnityEditor;

public class CambiarVelocidadVentana : EditorWindow
{
    private float[] opcionesVelocidad = { 0.25f, 0.5f, 1f, 2f, 4f };
    private int indexSeleccionado = 2; // �ndice inicial (1x velocidad)
    private bool pausado = false;

    [MenuItem("Debug/Cambiar Velocidad y Pausa")]
    static void MostrarVentana()
    {
        CambiarVelocidadVentana ventana = GetWindow<CambiarVelocidadVentana>("Cambiar Velocidad y Pausa");
        ventana.minSize = new Vector2(200, 150);
    }

    void OnGUI()
    {
        GUILayout.Label("Seleccionar Velocidad de Reproducci�n", EditorStyles.boldLabel);

        indexSeleccionado = GUILayout.Toolbar(indexSeleccionado, new string[] { "1/4", "1/2", "1x", "2x", "4x" });

        // Obtener la velocidad seleccionada
        float velocidadSeleccionada = opcionesVelocidad[indexSeleccionado];

        // Aplicar la velocidad al presionar el bot�n
        if (GUILayout.Button($"Aplicar {velocidadSeleccionada}x"))
        {
            Time.timeScale = velocidadSeleccionada;
            Debug.Log($"Velocidad de reproducci�n cambiada a {velocidadSeleccionada}x");
        }

        GUILayout.Space(10); // Espacio entre las opciones

        GUILayout.Label("Pausa", EditorStyles.boldLabel);

        // Bot�n para activar/desactivar la pausa
        pausado = GUILayout.Toggle(pausado, "Pausar");

        // Aplicar la pausa al presionar el bot�n
        if (GUILayout.Button($"Aplicar {(pausado ? "Pausa" : "Reanudar")}"))
        {
            Time.timeScale = pausado ? 0f : 1f;
            Debug.Log($"El juego est� {(pausado ? "pausado" : "reanudado")}");
        }
    }
}
