using Flax.Build;
using Flax.Build.NativeCpp;

public class UE4ContentImporterEditor : GameEditorModule
{
    /// <inheritdoc />
    public override void Setup(BuildOptions options)
    {
        base.Setup(options);

        BuildNativeCode = false;

        options.ScriptingAPI.FileReferences.Add(@"Dependencies\JollySamurai.UnrealEngine4.T3D.dll");
    }
}
