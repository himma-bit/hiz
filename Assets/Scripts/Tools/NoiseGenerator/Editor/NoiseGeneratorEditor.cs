﻿#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NoiseGenerator), true)]
public class NoiseGeneratorEditor: Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        NoiseGenerator myScript = (NoiseGenerator)target;
        if (GUILayout.Button("Generate Textures"))
        {
            myScript.Generate();
        }
    }
}
#endif