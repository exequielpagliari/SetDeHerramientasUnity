using UnityEngine;
using UnityEditor;

public class AlignToSurfaceEditor : EditorWindow
{
    
    public static void ShowWindow()
    {
        GetWindow<AlignToSurfaceEditor>("Alinear con Superficie");
    }

    private void OnGUI()
    {
        GUILayout.Label("Alinear objeto seleccionado con la superficie debajo", EditorStyles.boldLabel);

        if (GUILayout.Button("Alinear Objeto"))
        {
            AlinearObjeto();
        }
    }
    [MenuItem("Productividad/Alinear con Superficie &g")]
    public static void AlinearObjeto()
    {
        GameObject seleccionado = Selection.activeGameObject;

        if (seleccionado == null)
        {
            Debug.LogWarning("No hay un objeto seleccionado.");
            return;
        }

        Collider col = seleccionado.GetComponent<Collider>();
        if (col == null)
        {
            Debug.LogWarning("El objeto necesita tener un Collider.");
            return;
        }

        // Punto más bajo del bounding box
        Bounds bounds = col.bounds;
        Vector3 origen = new Vector3(bounds.center.x, bounds.min.y - 0.01f, bounds.center.z); // apenas debajo para evitar autocollision

        if (Physics.Raycast(origen, Vector3.down, out RaycastHit hit, 10f))
        {
            Undo.RecordObject(seleccionado.transform, "Alinear con superficie");

            seleccionado.transform.position = hit.point;

            // Alineación con la normal del terreno
            Quaternion rotacionActual = seleccionado.transform.rotation;
            Quaternion nuevaRotacion = Quaternion.FromToRotation(seleccionado.transform.up, hit.normal) * rotacionActual;
            seleccionado.transform.rotation = nuevaRotacion;

            Debug.Log($"Objeto alineado con superficie: {hit.collider.name}");
        }
        else
        {
            Debug.LogWarning("No se detectó ninguna superficie debajo del objeto.");
        }
    }
}
