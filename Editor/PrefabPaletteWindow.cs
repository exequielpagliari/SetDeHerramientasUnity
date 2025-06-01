using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PrefabPaletteWindow : EditorWindow
{
    private Vector2 scroll;
    private Dictionary<string, List<Object>> categorizedPrefabs = new();
    private string prefabFolder = "Assets/Prefabs/LevelDesign";
    private string selectedCategory = "All";

    [MenuItem("Window/Level Design/Prefab Palette")]
    public static void ShowWindow()
    {
        GetWindow<PrefabPaletteWindow>("Prefab Palette");
    }

    private void OnEnable()
    {
        LoadPrefabs();
    }

    private void LoadPrefabs()
    {
        categorizedPrefabs.Clear();
        categorizedPrefabs["All"] = new();

        string[] guids = AssetDatabase.FindAssets("t:Prefab", new[] { prefabFolder });
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Object prefab = AssetDatabase.LoadAssetAtPath<Object>(path);
            if (prefab == null) continue;

            string category = GetCategoryFromPath(path);
            if (!categorizedPrefabs.ContainsKey(category))
                categorizedPrefabs[category] = new();

            categorizedPrefabs[category].Add(prefab);
            categorizedPrefabs["All"].Add(prefab);
        }
    }

    private string GetCategoryFromPath(string path)
    {
        string relativePath = path.Replace(prefabFolder + "/", "");
        string[] parts = relativePath.Split('/');
        return parts.Length > 1 ? parts[0] : "Uncategorized";
    }

    private void OnGUI()
    {
        DrawCategoryToolbar();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Arrastra un prefab a la escena", EditorStyles.boldLabel);
        scroll = EditorGUILayout.BeginScrollView(scroll);

        if (!categorizedPrefabs.ContainsKey(selectedCategory)) return;

        var prefabs = categorizedPrefabs[selectedCategory];
        int columns = 3;
        int size = 80;
        int count = 0;

        EditorGUILayout.BeginHorizontal();
        foreach (var prefab in prefabs)
        {
            if (count % columns == 0 && count != 0)
            {
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.BeginHorizontal();
            }

            DrawPrefabButton(prefab, size);
            count++;
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndScrollView();
    }

    private void DrawCategoryToolbar()
    {
        EditorGUILayout.BeginHorizontal();

        foreach (var category in categorizedPrefabs.Keys)
        {
            GUI.color = category == selectedCategory ? Color.cyan : Color.white;
            if (GUILayout.Button(category, GUILayout.Height(25)))
            {
                selectedCategory = category;
            }
        }

        GUI.color = Color.white;
        EditorGUILayout.EndHorizontal();
    }

    private void DrawPrefabButton(Object prefab, int size)
    {
        GUILayout.BeginVertical(GUILayout.Width(size));

        Texture2D preview = AssetPreview.GetAssetPreview(prefab);
        if (!preview) preview = AssetPreview.GetMiniThumbnail(prefab);

        Rect rect = GUILayoutUtility.GetRect(size, size);
        GUI.DrawTexture(rect, preview, ScaleMode.ScaleToFit);

        if (Event.current.type == EventType.MouseDown && rect.Contains(Event.current.mousePosition))
        {
            DragAndDrop.PrepareStartDrag();
            DragAndDrop.objectReferences = new[] { prefab };
            DragAndDrop.StartDrag("Dragging Prefab");
            Event.current.Use();
        }

        GUILayout.Label(prefab.name, EditorStyles.centeredGreyMiniLabel);
        GUILayout.EndVertical();
    }
}
