using UnityEditor;
using UnityEngine;

namespace Editor.Inspector
{
    [CustomEditor(typeof(RiverManager))]
    public class RiverManagerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
        
            var script = (RiverManager) target;
            if(GUILayout.Button("Next Stage"))
            {
                script.NextStage();
            }
            
            if(GUILayout.Button("Previous Stage"))
            {
                script.PreviousStage();
            }
        }
    }
}