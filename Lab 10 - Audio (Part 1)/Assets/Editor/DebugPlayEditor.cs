using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DebugPlay))]
public class DebugPlayEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DebugPlay myTarget = (DebugPlay) target;
        
        if (GUILayout.Button("Play sound")) myTarget.Play();
        if (GUILayout.Button("Play sound with reverb")) myTarget.PlayWithReverb();
        if (GUILayout.Button("Play sound without reverb")) myTarget.PlayWithoutReverb();
    }
}
