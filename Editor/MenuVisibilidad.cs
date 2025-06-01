using UnityEngine;
using UnityEditor;

public class MenuVisivilidad : MonoBehaviour
{
    private const string nombreSubmenu = "Productividad/Mostrar Objetos/";

    [MenuItem(nombreSubmenu + "Ocultar Todos Excepto Seleccionados")]
    static void OcultarTodosExceptoSeleccionados()
    {
        GameObject[] todosLosObjetos = GameObject.FindObjectsByType<GameObject>( FindObjectsSortMode.None );

        foreach (GameObject obj in todosLosObjetos)
        {
            if (Selection.Contains(obj))
                obj.SetActive(true);
            else
                obj.SetActive(false);
        }
    }

    [MenuItem(nombreSubmenu + "Mostrar Todos")]
    static void MostrarTodos()
    {
        GameObject[] todosLosObjetos = Resources.FindObjectsOfTypeAll<GameObject>();
        Debug.Log(todosLosObjetos.Length);
        foreach (GameObject obj in todosLosObjetos)
        {
            obj.SetActive(true);
        }
    }

    [MenuItem(nombreSubmenu + "Ocultar Seleccionados")]
    static void OcultarSeleccionados()
    {
        GameObject[] objetosSeleccionados = Selection.gameObjects;

        foreach (GameObject obj in objetosSeleccionados)
        {
            obj.SetActive(false);
        }
    }
}
