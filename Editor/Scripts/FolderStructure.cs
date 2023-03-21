using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;


namespace FourDoor
{
    public static class FolderStructure
    {
        private static string[] setupDirectories = new[]
        {
            "Art", "Scenes", "Shaders", "Textures", "Materials", "Scripts", "Fonts",
            "Audio", "Prefabs", "Resources", "RenderSettings"
        };
        
        public static void CreateDefaultFolderStructure()
        {
            Dir("_FD", setupDirectories);
            CreateDirectory(Combine(dataPath, "ThirdPartyAssets"));
            Refresh();
        }

        public static void Dir(string root, params string[] dir)
        {
            var rootPath = Combine(dataPath, root);
            
            foreach (string newDirectory in dir)
            {
               CreateDirectory(Combine(rootPath, newDirectory));
            }
        }
    }
}
