using UnityEditor;
using UnityEngine;

public class MenuAtajosLocaciones : Editor
{
    private static Vector3[] posicionesGuardadas = new Vector3[10];
    private static Quaternion[] rotacionesGuardadas = new Quaternion[10];

    [MenuItem("Productividad/Locaciones/Guardar Locacion 1 %#&1")]
    private static void GuardarLocacion1()
    {
        GuardarLocacion(0);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 2 %#&2")]
    private static void GuardarLocacion2()
    {
        GuardarLocacion(1);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 3 %#&3")]
    private static void GuardarLocacion3()
    {
        GuardarLocacion(2);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 4 %#&4")]
    private static void GuardarLocacion4()
    {
        GuardarLocacion(3);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 5 %#&5")]
    private static void GuardarLocacion5()
    {
        GuardarLocacion(4);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 6 %#&6")]
    private static void GuardarLocacion6()
    {
        GuardarLocacion(5);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 7 %#&7")]
    private static void GuardarLocacion7()
    {
        GuardarLocacion(6);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 8 %#&8")]
    private static void GuardarLocacion8()
    {
        GuardarLocacion(7);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 9 %#&9")]
    private static void GuardarLocacion9()
    {
        GuardarLocacion(8);
    }

    [MenuItem("Productividad/Locaciones/Guardar Locacion 10 %#&0")]
    private static void GuardarLocacion10()
    {
        GuardarLocacion(9);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 1 #&1")]
    private static void IrALocacion1()
    {
        IrALocacion(0);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 2 #&2")]
    private static void IrALocacion2()
    {
        IrALocacion(1);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 3 #&3")]
    private static void IrALocacion3()
    {
        IrALocacion(2);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 4 #&4")]
    private static void IrALocacion4()
    {
        IrALocacion(3);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 5 #&5")]
    private static void IrALocacion5()
    {
        IrALocacion(4);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 6 #&6")]
    private static void IrALocacion6()
    {
        IrALocacion(5);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 7 #&7")]
    private static void IrALocacion7()
    {
        IrALocacion(6);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 8 #&8")]
    private static void IrALocacion8()
    {
        IrALocacion(7);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 9 #&9")]
    private static void IrALocacion9()
    {
        IrALocacion(8);
    }

    [MenuItem("Productividad/Locaciones/Ir a Locacion 10 #&0")]
    private static void IrALocacion10()
    {
        IrALocacion(9);
    }

    private static void GuardarLocacion(int indice)
    {
        SceneView sceneView = SceneView.lastActiveSceneView;

        if (sceneView != null)
        {
            posicionesGuardadas[indice] = sceneView.pivot;
            rotacionesGuardadas[indice] = sceneView.rotation;
            Debug.Log($"Locacion {indice + 1} guardada en {sceneView.pivot} con rotacion {sceneView.rotation}.");
        }
        else
        {
            Debug.LogWarning("Activa la vista de la escena para guardar la locacion.");
        }
    }

    private static void IrALocacion(int indice)
    {
        if (posicionesGuardadas[indice] != new Vector3(0,0,0))
        {
            SceneView.lastActiveSceneView.pivot = posicionesGuardadas[indice];
            SceneView.lastActiveSceneView.rotation = rotacionesGuardadas[indice];
            SceneView.RepaintAll();
            Debug.Log($"Moviendo la vista del editor a Locacion {indice + 1}.");
        }
        else
        {
            Debug.LogWarning($"La Locacion {indice + 1} no ha sido guardada.");
        }
    }
}
