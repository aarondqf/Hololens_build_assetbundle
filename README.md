用unity打开工程之后，在unity菜单栏点击 Assets->BuildBundles生成assetbundle

打包出来的.unity3d 文件放置在 "Assets/Bundles_downloaded"目录下面

在本工程中，fbx文件均放置在 "Assets/Resources"目录下面，fbx文件需要设置AssetBundle，本工程中，设置的AssetBundle的名字是hololens_fbxs， 后缀是unity3d。

注意：
1)生成bundle的脚本文件必须放置在"Assets/Editor"目录下，本工程中的生成bundle的脚本的路径是"Assets/Editor/MyAssetBundles.cs"
2)本工程在脚本打包设置的目标平台是BuildTarget.WSAPlayer
