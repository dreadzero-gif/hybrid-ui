using Blish_HUD;
using HybridUI.Core;

namespace HybridUI.BlishHUD
{
    public class HybridUIModule : BlishHUDModule
    {
        protected override void Initialize()
        {
            HybridUI.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            // Update HUD components
        }
    }
}
