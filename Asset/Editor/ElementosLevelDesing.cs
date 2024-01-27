
using UnityEditor;
using UnityEngine;


public class ElementosLevelDesing : MonoBehaviour
{
    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    [MenuItem("ElementosLevelDesing/Agregar Script/Agregar Script Plataforma")]

    static void AgregarScriptPlataformat()
    {
        // Selecciona el GameObject actual
        GameObject selectedObject = Selection.activeGameObject;

        // Verifica si hay un GameObject seleccionado
        if (selectedObject != null)
        {
            // Agrega el script al GameObject
            selectedObject.AddComponent<Plataforma>(); 
        }
        else
        {
            Debug.LogWarning("No hay ningún GameObject seleccionado.");
        }
    }

    [MenuItem("ElementosLevelDesing/Agregar Script/Agregar Script Plataforma Con Retardo")]

    static void AgregarScriptPlataformaConRetardo()
    {
        // Selecciona el GameObject actual
        GameObject selectedObject = Selection.activeGameObject;

        // Verifica si hay un GameObject seleccionado
        if (selectedObject != null)
        {
            // Agrega el script al GameObject
            selectedObject.AddComponent<PlataformaConRetardo>();
        }
        else
        {
            Debug.LogWarning("No hay ningún GameObject seleccionado.");
        }
    }

    [MenuItem("ElementosLevelDesing/Agregar Script/Agregar Script Obstáculo")]

    static void AgregarScriptObstaculo()
    {
        // Selecciona el GameObject actual
        GameObject selectedObject = Selection.activeGameObject;

        // Verifica si hay un GameObject seleccionado
        if (selectedObject != null)
        {
            // Agrega el script al GameObject
            selectedObject.AddComponent<Obstaculo>();
        }
        else
        {
            Debug.LogWarning("No hay ningún GameObject seleccionado.");
        }
    }

    [MenuItem("ElementosLevelDesing/Agregar Script/Agregar Script Lanzador")]

    static void AgregarScriptLanzador()
    {
        // Selecciona el GameObject actual
        GameObject selectedObject = Selection.activeGameObject;

        // Verifica si hay un GameObject seleccionado
        if (selectedObject != null)
        {
            // Agrega el script al GameObject
            selectedObject.AddComponent<Lanzador>();
        }
        else
        {
            Debug.LogWarning("No hay ningún GameObject seleccionado.");
        }
    }

    [MenuItem("ElementosLevelDesing/Agregar Script/Agregar Script Rotatorio")]

    static void AgregarScriptRotatorio()
    {
        // Selecciona el GameObject actual
        GameObject selectedObject = Selection.activeGameObject;

        // Verifica si hay un GameObject seleccionado
        if (selectedObject != null)
        {
            // Agrega el script al GameObject
            selectedObject.AddComponent<Rotatorio>();
        }
        else
        {
            Debug.LogWarning("No hay ningún GameObject seleccionado.");
        }
    }
    [MenuItem("ElementosLevelDesing/Agregar Script/Agregar Script Rotatorio Con Límite")]
    static void AgregarScriptRotatorioConLimite()
    {
        // Selecciona el GameObject actual
        GameObject selectedObject = Selection.activeGameObject;

        // Verifica si hay un GameObject seleccionado
        if (selectedObject != null)
        {
            // Agrega el script al GameObject
            selectedObject.AddComponent<RotatorioConlimite>();
        }
        else
        {
            Debug.LogWarning("No hay ningún GameObject seleccionado.");
        }
    }

    [MenuItem("ElementosLevelDesing/Crear Nuevo Objeto/Crear Plataforma")]
    static void CrearPlataformaNueva()
    {
        // Crea un nuevo objeto
        GameObject nuevoObjeto = new GameObject("Plataforma");

        // Haz que el objeto sea seleccionado
        Selection.activeGameObject = nuevoObjeto;
    }

    [MenuItem("ElementosLevelDesing/Crear Nuevo Objeto/Crear Plataforma Con Retardo")]
    static void CrearPlataformaConRetardoNueva()
    {
        // Crea un nuevo objeto
        GameObject nuevoObjeto = new GameObject("PlataformaConRetardo");

        // Haz que el objeto sea seleccionado
        Selection.activeGameObject = nuevoObjeto;
    }

    [MenuItem("ElementosLevelDesing/Crear Nuevo Objeto/Crear Obstáculo")]
    static void CrearObstaculo()
    {
        // Crea un nuevo objeto
        GameObject nuevoObjeto = new GameObject("Obstaculo");

        // Haz que el objeto sea seleccionado
        Selection.activeGameObject = nuevoObjeto;
    }

    [MenuItem("ElementosLevelDesing/Crear Nuevo Objeto/Crear Lanzador")]
    static void CrearLanzador()
    {
        // Crea un nuevo objeto
        GameObject nuevoObjeto = new GameObject("Lanzador");

        // Haz que el objeto sea seleccionado
        Selection.activeGameObject = nuevoObjeto;
    }

    [MenuItem("ElementosLevelDesing/Crear Nuevo Objeto/Crear Rotatorio")]
    static void CrearRotatorio()
    {
        // Crea un nuevo objeto
        GameObject nuevoObjeto = new GameObject("Rotatorio");

        // Haz que el objeto sea seleccionado
        Selection.activeGameObject = nuevoObjeto;
    }

    [MenuItem("ElementosLevelDesing/Crear Nuevo Objeto/Crear RotatorioConLímite")]
    static void CrearRotatorioConRetorno()
    {
        // Crea un nuevo objeto
        GameObject nuevoObjeto = new GameObject("RotatorioConLimite");

        // Haz que el objeto sea seleccionado
        Selection.activeGameObject = nuevoObjeto;
    }
}
