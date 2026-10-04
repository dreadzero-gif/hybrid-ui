using Blish_HUD;
using Blish_HUD.GameServices;
using HybridUI.Combat;

namespace HybridUI.BlishHUD
{
    public class GW2CombatAdapter : CombatAdapter
    {
        public override void Initialize()
        {
            GameService.Gw2Mumble.PlayerCharacterChanged += (_, _) =>
            {
                OnPlayerChanged();
            };

            GameService.Gw2Mumble.CurrentMapChanged += (_, _) =>
            {
                OnMapChanged();
            };
        }

        public override void Update(float delta)
        {
            // Hook into Blish HUD combat events here
        }
    }
}
