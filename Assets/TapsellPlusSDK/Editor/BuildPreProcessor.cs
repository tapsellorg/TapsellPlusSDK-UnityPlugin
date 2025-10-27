using System;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
#if UNITY_2018_1_OR_NEWER
using UnityEditor.Build.Reporting;

#endif

#if UNITY_2018_1_OR_NEWER
public class BuildPreProcessor : IPreprocessBuildWithReport
#else
public class BuildPreProcessor : IPreprocessBuild
#endif
{
    public int callbackOrder
    {
        get { return 1; }
    }

#if UNITY_2018_1_OR_NEWER
    public void OnPreprocessBuild(BuildReport report)
#else
    public void OnPreprocessBuild(BuildTarget target, string path)
#endif
    {
        // Warns user from the importing Admob package with above the specific version
        // Also User should not have several manifest files. It can be a confusion. Because detecting admob version will be impossible
        if (!AssetDatabase.IsValidFolder("Assets/GoogleMobileAds")) return;

        try
        {
            string latestTestedAdmobVersion = "8.2.0";
            string[] manifestPaths = AssetDatabase.FindAssets("GoogleMobileAds_version",
                new[] {"Assets/GoogleMobileAds"});

            foreach (var path in manifestPaths)
            {
                // address of every asset is a hash by default
                string manifestPath = AssetDatabase.GUIDToAssetPath(path);

                // fetching version from `GoogleMobileAds_version-{X.X.X}_manifest.txt` file. 
                // Corner case: user may have several manifest.txt or none of them by mistake
                string versionString = manifestPath.Substring(47, 5);
                var currentAdmobVersion = new Version(versionString);
                var versionToCompare = new Version(latestTestedAdmobVersion);
                if (currentAdmobVersion > versionToCompare)
                {
                    Debug.LogWarning("Latest tested version for GoogleMobileAds is:" +
                                               latestTestedAdmobVersion + "Your version is:" + currentAdmobVersion);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}