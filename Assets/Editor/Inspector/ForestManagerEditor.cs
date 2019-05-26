using UnityEditor;
using UnityEngine;

namespace Editor.Inspector
{
    [CustomEditor(typeof(ForestManager))]
    public class ForestManagerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
        
            var script = (ForestManager) target;
            if(GUILayout.Button("Next Stage"))
            {
                script.NextStage();
            }
        }
    }
}