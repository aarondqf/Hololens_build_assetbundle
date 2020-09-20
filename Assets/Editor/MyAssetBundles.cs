using UnityEngine;
using UnityEditor;
using System.IO;

public class MyAssetBundles : MonoBehaviour
{
    [MenuItem("Assets/BuildBundles")]//在Assets选项中添加点击按钮
    static void BuildBundles()
    {
        string assetBundlesLibrary = "Assets/Bundles_downloaded";
        if (!Directory.Exists(assetBundlesLibrary))//判断本地目录是否已经存在目录名
        {
            Directory.CreateDirectory(assetBundlesLibrary);
        }

        BuildPipeline.BuildAssetBundles(assetBundlesLibrary, BuildAssetBundleOptions.None,
            BuildTarget.WSAPlayer);//在此目录下创建AssetBundle
    }
}
