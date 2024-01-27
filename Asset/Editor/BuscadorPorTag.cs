using UnityEngine;
using UnityEditor;



    public class BuscadorPorTag : EditorWindow
    {
    
    [MenuItem("Productividad/Buscar Todos con Tag")]
    static void Init()
    {



           
        
        BuscadorPorTag window = ScriptableObject.CreateInstance<BuscadorPorTag>();
        float height = UnityEditorInternal.InternalEditorUtility.tags.Length * 21;
        window.position = new Rect(Screen.width / 2, Screen.height / 2 - height / 2, 250, height);
        window.ShowPopup();
    }

    void OnGUI()
    {
        foreach (string tag in UnityEditorInternal.InternalEditorUtility.tags)
        {
            if (GUILayout.Button($"Seleccionar Todos con Tag '{tag}'"))
            {
                GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);

                if (objectsWithTag != null && objectsWithTag.Length > 0)
                {
                    Debug.Log("Se Seleccionaron " + objectsWithTag.Length + " Objetos");
                    Selection.objects = objectsWithTag;
                }
                else
                {
                    Debug.Log($"No hay Game Objects con el tag {tag} en el hierarchy");
                }

                Close();
            }
        }
    }
    
}

