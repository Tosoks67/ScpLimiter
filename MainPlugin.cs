using JetBrains.Annotations;
using LabApi.Events.Handlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using MEC;
using PlayerRoles;
using Logger = LabApi.Features.Console.Logger;
using Player = LabApi.Features.Wrappers.Player;

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
        ServerEvents.RoundStarted += OnRoundStarted;
    }

    public override void Disable()
    {
        ServerEvents.RoundStarted -= OnRoundStarted;
    }

    private void OnRoundStarted()
    {
        Timing.CallDelayed(
            0.75f,
            () =>
            {
                foreach (var player in Player.ReadyList
                             .Where(static player => player.Team is Team.SCPs)
                             .ToShuffled()
                             .Skip(Config.ScpLimit))
                {
#if DEBUG
                    Logger.Raw(
                        $"[{Name}] Changing {player.Nickname} ({player.PlayerId}) " +
                        $"from {player.Role} to {Config.SubstituteRole}",
                        ConsoleColor.Yellow
                    );
#endif
                    player.Role = Config.SubstituteRole;
                }
            }
        );
    }
}
