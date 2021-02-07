using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomPopupWindow : EditorWindow {

    [MenuItem("Window/CustomPopupWindow")]
    static void Open() {
        GetWindow<CustomPopupWindow>();
    }

    CustomPopupContent popupContent = new CustomPopupContent();

    private void OnGUI()
    {
        if (GUILayout.Button("CustomPopupContent", GUILayout.Width(256)))
        {
            var activatorRect = GUILayoutUtility.GetLastRect();

            PopupWindow.Show(activatorRect, popupContent);
        }
    }
}

public class CustomPopupContent : PopupWindowContent
{
    public override void OnGUI(Rect rect)
    {
        EditorGUILayout.LabelField("Label");
    }

    public override void OnOpen()
    {
        base.OnOpen();
        Debug.Log("OnOpen()");
    }

    public override void OnClose()
    {
        base.OnClose();
        Debug.Log("OnClose()");
    }

    public override Vector2 GetWindowSize()
    {
        return base.GetWindowSize();
    }
}

