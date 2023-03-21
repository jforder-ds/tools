using UnityEditor;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace FourDoor
{
    public static class ToolBar
    {
        private const string RootName = "FD";

        #region Project Setup

        [MenuItem(RootName + "/Project/Setup Project")]
        public static void FullProjectDefaults()
        {
            if (EditorUtility.DisplayDialog("New Project Setup",
                    "Are you sure you want to setup a new project, some changes may be lost", "Setup", "Cancel"))
            {
                ProjectSettings.SetRootNamespace("FourDoor");
                ProjectSettings.ChangeCompanyName("Four Door Productions ltd");
                ProjectSettings.EnterPlayMode();
                FolderStructure.CreateDefaultFolderStructure();
                AssetCreation.CreateSceneAsset("Main", "_FD/Scenes/");
            }
        }
       
        public static void AddDefaultFolders()
        {
            FolderStructure.CreateDefaultFolderStructure();
        }

        #endregion
        
        #region Packages

        [MenuItem(RootName + "/Packages/Default Project Packages")]
        public static async void LoadDefaultPackages()
        {
            var url = Packages.GetGistURL("7db3668599de415c7a1cd636e4d25f8a");
            var contents = await Packages.GetContents(url);
            Packages.ReplacePackageFile(contents);
        }
        
        [MenuItem(RootName + "/Packages/Internal/Core")]
        public static async void LoadCoreInternal()
        {
            var url = Packages.GetGistURL("7db3668599de415c7a1cd636e4d25f8a");
            var contents = await Packages.GetContents(url);
            Packages.ReplacePackageFile(contents);
        }

        [MenuItem(RootName + "/Packages/XR/ARCore (Android)")]
        public static void LoadXRPackagesAndroid()
        {
            Packages.InstallUnityPackage("xr.arfoundation");
            Packages.InstallUnityPackage("xr.arcore");
            Packages.InstallUnityPackage("xr.management");
        }
        
        [MenuItem(RootName + "/Packages/XR/ARKIT (iOS)")]
        public static void LoadXRPackagesIOS()
        {
            Packages.InstallUnityPackage("xr.arfoundation");
            Packages.InstallUnityPackage("xr.arkit");
            Packages.InstallUnityPackage("xr.management");
        }
        
        [MenuItem(RootName + "/Packages/XR/All XR")]
        public static void LoadXRPackagesAll()
        {
            LoadXRPackagesAndroid();
            LoadXRPackagesIOS();
        }
        
        [MenuItem(RootName + "/Packages/XR/Face Tracking (iOS)")]
        public static void LoadXRPackagesFaceIOS()
        {
            Packages.InstallUnityPackage("xr.arfoundation");
            Packages.InstallUnityPackage("xr.arkit-face-tracking");
            Packages.InstallUnityPackage("xr.management");
        }
        
        [MenuItem(RootName + "/Packages/XR/Oculus XR")]
        public static void LoadOculusXR()
        {
            Packages.InstallUnityPackage("xr.oculus");
        }
        
        [MenuItem(RootName + "/Packages/Sequencing/Timeline")]
        public static void LoadTimelinePackage()
        {
            Packages.InstallUnityPackage("timeline");
        }
        
        [MenuItem(RootName + "/Packages/Sequencing/CineMachine")]
        public static void LoadCineMachinePackage()
        {
            Packages.InstallUnityPackage("cinemachine");
        }

        [MenuItem(RootName + "/Packages/Rendering/URP")]
        public static void LoadURPPackage()
        {
            Packages.InstallUnityPackage("render-pipelines.universal");
        }
        
        [MenuItem(RootName + "/Packages/Rendering/Shader Graph")]
        public static void LoadShaderGraphPackage()
        {
            Packages.InstallUnityPackage("shadergraph");
        }

        #endregion

        #region EditorHotkeys
        
        [Shortcut("Escape", KeyCode.KeypadEnter, ShortcutModifiers.Alt)]
        public static void EnterPlayMode()
        {
            EditorApplication.isPlaying = true;
        }
        
        #endregion
    }
}