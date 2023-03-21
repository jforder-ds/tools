using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;
using static System.IO.Path;

namespace FourDoor
{
    public static class AssetCreation
    {
        public static void CreateSceneAsset(string sceneName, string path)
        {
            var scenePath = Combine(dataPath, path + $"{sceneName}.unity");
            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            scene.name = sceneName;
            EditorSceneManager.SaveScene(scene, scenePath);
            Refresh();
        }
    }
}

