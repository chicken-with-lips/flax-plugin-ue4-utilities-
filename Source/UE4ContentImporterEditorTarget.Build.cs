using Flax.Build;

public class UE4ContentImporterEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("UE4ContentImporterEditor");
    }
}
