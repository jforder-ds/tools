using UnityEditor;

namespace FourDoor
{
    public static class ProjectSettings
    {
        public static void SetRootNamespace(string rootNamespace)
        {
            EditorSettings.projectGenerationRootNamespace = rootNamespace;
        }

        public static void EnterPlayMode(bool active = true)
        {
            EditorSettings.enterPlayModeOptionsEnabled = active;
        }

        public static void ChangeCompanyName(string companyName)
        {
            PlayerSettings.companyName = companyName;
        }
    }
}