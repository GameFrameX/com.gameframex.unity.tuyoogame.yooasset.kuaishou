#if UNITY_WEBGL && ENABLE_KUAISHOU_MINI_GAME && KUAISHOUMINIGAME
using YooAsset;

namespace YooAsset.KuaiShou
{
    [UnityEngine.Scripting.Preserve]
    public static class KuaiShouFileSystemCreater
    {
        [UnityEngine.Scripting.Preserve]
        public static FileSystemParameters CreateKuaiShouFileSystemParameters(IRemoteServices remoteServices = null, KuaiShouFileSystemOption option = null)
        {
            string fileSystemClass = typeof(KuaiShouFileSystem).FullName;
            var fileSystemParams = new FileSystemParameters(fileSystemClass, null);
            fileSystemParams.AddParameter(FileSystemParametersDefine.REMOTE_SERVICES, remoteServices);
            fileSystemParams.AddParameter(KuaiShouFileSystemOption.ParameterKey, option ?? new KuaiShouFileSystemOption());
            return fileSystemParams;
        }

        [UnityEngine.Scripting.Preserve]
        public static FileSystemParameters CreateKuaiShouPathFileSystemParameters(string buildinPackRoot, KuaiShouFileSystemOption option = null)
        {
            string fileSystemClass = typeof(KuaiShouFileSystem).FullName;
            var fileSystemParams = new FileSystemParameters(fileSystemClass, null);
            var remoteServices = new KuaiShouFileSystem.WebRemoteServices(buildinPackRoot);
            fileSystemParams.AddParameter(FileSystemParametersDefine.REMOTE_SERVICES, remoteServices);
            fileSystemParams.AddParameter(KuaiShouFileSystemOption.ParameterKey, option ?? new KuaiShouFileSystemOption());
            return fileSystemParams;
        }
    }
}

#endif