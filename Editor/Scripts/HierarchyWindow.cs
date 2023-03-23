using UnityEditor;
using UnityEngine;

namespace FourDoor
{
    [InitializeOnLoad]
    public class HierarchyWindow : MonoBehaviour
    {
        const string IgnoreIcons = "GameObject Icon, Prefab Icon";

        static HierarchyWindow()
        {
            EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
        }

        static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
        {
            var content = EditorGUIUtility.ObjectContent(EditorUtility.InstanceIDToObject(instanceID), null);

            if (content.image != null)
                GUI.DrawTexture(new Rect(selectionRect.xMax - 16, selectionRect.yMin, 16, 16), content.image);
            
        }
    }
}
