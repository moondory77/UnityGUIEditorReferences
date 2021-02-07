using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

class CustomPopup : EditorWindow
{
    static CustomPopup customPopup;

    [MenuItem("Window/CustomPopup")]
    static void Open()
    {
        if (customPopup == null) {
            customPopup = CreateInstance<CustomPopup>();
        }
        customPopup.ShowPopup();
    }

    private void OnGUI()
    {
        if (Event.current.keyCode == KeyCode.Escape)
        {
            customPopup.Close();
        }
    }
}

