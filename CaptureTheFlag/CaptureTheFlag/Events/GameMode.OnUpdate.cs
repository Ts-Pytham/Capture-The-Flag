using CaptureTheFlag.PropertiesPlayer;
using SampSharp.GameMode;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;

namespace CaptureTheFlag.Events
{
    public partial class GameMode : BaseMode
    {
        protected override void OnPlayerUpdate(BasePlayer sender, PlayerUpdateEventArgs e)
        {
            var player = sender as Player;
            if (player.SpeedTime != 0 && player.SpeedTime < Time.GetTime())
            {
                player.ClearAnimations();
                player.SpeedTime = 0;
            }
        }
    }
}