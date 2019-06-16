using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraMove))]
public class ButtonMoveCamera : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        CameraMove camMove = (CameraMove)target;

        if(GUILayout.Button("On / Off - mouse move"))
        {
            camMove.OnOffMoveMouse();
        }
    }
}
