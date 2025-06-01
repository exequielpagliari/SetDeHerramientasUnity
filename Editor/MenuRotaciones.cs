using UnityEditor;
using UnityEngine;

public class MenuRotaciones : Editor
{
    [MenuItem("Productividad/Rotaciones/Rotar Global X -45")]
    private static void RotarGlobalXNeg45()
    {
        RotarSeleccionado(Quaternion.Euler(-45, 0, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Global X 45")]
    private static void RotarGlobalXPos45()
    {
        RotarSeleccionado(Quaternion.Euler(45, 0, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Global Y -45")]
    private static void RotarGlobalYNeg45()
    {
        RotarSeleccionado(Quaternion.Euler(0, -45, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Global Y 45")]
    private static void RotarGlobalYPos45()
    {
        RotarSeleccionado(Quaternion.Euler(0, 45, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Global Z -45")]
    private static void RotarGlobalZNeg45()
    {
        RotarSeleccionado(Quaternion.Euler(0, 0, -45));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Global Z 45")]
    private static void RotarGlobalZPos45()
    {
        RotarSeleccionado(Quaternion.Euler(0, 0, 45));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Local X -45 %#DOWN")]
    private static void RotarLocalXNeg45()
    {
        RotarSeleccionadoLocal(Quaternion.Euler(-45, 0, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Local X 45 %#UP")]
    private static void RotarLocalXPos45()
    {
        RotarSeleccionadoLocal(Quaternion.Euler(45, 0, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Local Y -45 %#LEFT")]
    private static void RotarLocalYNeg45()
    {
        RotarSeleccionadoLocal(Quaternion.Euler(0, -45, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Local Y 45 %#RIGHT")]
    private static void RotarLocalYPos45()
    {
        RotarSeleccionadoLocal(Quaternion.Euler(0, 45, 0));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Local Z -45")]
    private static void RotarLocalZNeg45()
    {
        RotarSeleccionadoLocal(Quaternion.Euler(0, 0, -45));
    }

    [MenuItem("Productividad/Rotaciones/Rotar Local Z 45")]
    private static void RotarLocalZPos45()
    {
        RotarSeleccionadoLocal(Quaternion.Euler(0, 0, 45));
    }



    private static void RotarSeleccionado(Quaternion rotacion)
    {
        if (Selection.activeGameObject != null)
        {
            Undo.RecordObject(Selection.activeGameObject.transform, "Rotar Global");
            Selection.activeGameObject.transform.rotation *= rotacion;
        }
        else
        {
            Debug.LogWarning("Selecciona un GameObject para rotar.");
        }
    }

    private static void RotarSeleccionadoLocal(Quaternion rotacion)
    {
        if (Selection.activeGameObject != null)
        {
            Undo.RecordObject(Selection.activeGameObject.transform, "Rotar Local");
            Selection.activeGameObject.transform.localRotation *= rotacion;
        }
        else
        {
            Debug.LogWarning("Selecciona un GameObject para rotar localmente.");
        }
    }
}