using UnityEditor;

public class CreateAssetsBundels
{
    [MenuItem("Assets/Build AssetsBundel")]
    static void BuildAllAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/AssetsBundel", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
