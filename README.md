# Game Frame X YooAsset MiniGame KuaiShou

YooAsset 快手小游戏适配包，提供快手小游戏平台的资源文件系统（`KuaiShouFileSystem`）。

## 依赖

- `com.gameframex.unity.tuyoogame.yooasset` >= 2.9.4
- 快手小游戏 Unity 转换 SDK（`com.kuaishou.minigame`，提供 `KSWASM` 命名空间）

## 激活条件

代码由 `UNITY_WEBGL && ENABLE_KUAISHOU_MINI_GAME` 宏保护。安装快手 SDK（`com.kuaishou.minigame`）后由 asmdef `versionDefines` 自动定义 `ENABLE_KUAISHOU_MINI_GAME` 宏并激活。

## 使用

通过 `KuaiShouFileSystemCreater` 创建文件系统参数，接入 YooAsset 初始化流程：

```csharp
using GameFrameX.Asset.YooAsset.Minigame.KuaiShou.Runtime;
using YooAsset;

var package = YooAssets.CreatePackage("DefaultPackage");
var createParameters = new WebPlayModeParameters();
createParameters.FileSystemParameters = KuaiShouFileSystemCreater.CreateKuaiShouFileSystemParameters(remoteServices);
```

## License

本项目采用 MIT 许可证与 Apache License 2.0 双许可证分发，详见 [LICENSE.md](LICENSE.md)。
