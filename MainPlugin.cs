using JetBrains.Annotations;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace ScpLimiter;

[UsedImplicitly]
public class MainPlugin : Plugin<Config>
{
    public override string Name => nameof(ScpLimiter);
    public override string Description => "Limits SCPs per round";
    public override string Author => "Tosoks67";
    public override Version RequiredApiVersion => LabApiProperties.CurrentVersion;

    public override void Enable()
    {
        throw new NotImplementedException();
    }

    public override void Disable()
    {
        throw new NotImplementedException();
    }
}
