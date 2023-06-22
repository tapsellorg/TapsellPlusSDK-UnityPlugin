using System;
using UnityEditor;
using UnityEditor.Build;
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
        // Prevent user from the importing Admob package with version of above the 7.1.0 
        // Also User should not have several manifest files. It can be a confusion. Because detecting admob version will be impossible
        if (!AssetDatabase.IsValidFolder("Assets/GoogleMobileAds")) return;

        try
        {
            string[] manifestPaths = AssetDatabase.FindAssets("GoogleMobileAds_version",
                new[] {"Assets/GoogleMobileAds"});
            
            foreach (var path in manifestPaths)
            {
                // address of every asset is a hash by default
                string manifestPath = AssetDatabase.GUIDToAssetPath(path);

                // fetching version from `GoogleMobileAds_version-{X.X.X}_manifest.txt` file. 
                // Corner case: user may have several manifest.txt or none of them by mistake
                string versionString = manifestPath.Substring(47, 5);
                var currentVersion = new Version(versionString);
                var versionToCompare = new Version("7.1.0");
                if (currentVersion > versionToCompare)
                {
                    // throw new BuildFailedException("Tapsell does not support This Admob version: " + currentVersion);
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