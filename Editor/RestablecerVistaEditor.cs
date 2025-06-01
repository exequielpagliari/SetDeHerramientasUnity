using UnityEditor;
using UnityEngine;

public class RestablecerVistaEditor : Editor
{
    private const string menuPath = "Productividad/Restablecer/";

    [MenuItem(menuPath + "Vista de Escena")]
    private static void RestablecerVistaEscena()
    {
        SceneView.lastActiveSceneView.rotation = Quaternion.identity;
        SceneView.RepaintAll();
        Debug.Log("Vista de escena restablecida.");
    }

    [MenuItem(menuPath + "Vista de Escena a Rotacion Predeterminada")]
    private static void RestablecerVistaEscenaRotacionPredeterminada()
    {
        Quaternion defaultRotation = Quaternion.Euler(30f, 45f, 0f); // Ajusta según sea necesario
        SceneView.lastActiveSceneView.rotation = defaultRotation;
        SceneView.RepaintAll();
        Debug.Log("Vista de escena restablecida a rotación predeterminada.");
    }

    [MenuItem(menuPath + "Vista de Escena a 2D")]
    private static void RestablecerVistaEscena2D()
    {
        SceneView.lastActiveSceneView.rotation = Quaternion.Euler(90f, 0f, 0f);
        SceneView.RepaintAll();
        Debug.Log("Vista de escena restablecida a vista 2D.");
    }

    [MenuItem(menuPath + "Vista de Escena a 3D")]
    private static void RestablecerVistaEscena3D()
    {
        SceneView.lastActiveSceneView.rotation = Quaternion.identity;
        SceneView.RepaintAll();
        Debug.Log("Vista de escena restablecida a vista 3D.");
    }
}
