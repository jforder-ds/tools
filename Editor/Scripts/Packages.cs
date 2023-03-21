using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace FourDoor
{
    public static class Packages
    {
        public static string GetGistURL(string id, string user = "jforder-ds")
        {
            return $"https://gist.github.com/{user}/{id}/raw";
        }

        public static async Task<string> GetContents(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public static void ReplacePackageFile(string content)
        {
            var existing = Path.Combine(Application.dataPath, "../Packages/manifest.json");
            File.WriteAllText(existing, content);
            UnityEditor.PackageManager.Client.Resolve();
        }

        public static void InstallUnityPackage(string packageName)
        {
            UnityEditor.PackageManager.Client.Add($"com.unity.{packageName}");
        }

        public static void InstallThirdPartyPackage(string packageName)
        {
            UnityEditor.PackageManager.Client.Add($"{packageName}");
        }
    }
}