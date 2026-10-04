using Blish_HUD;
using Blish_HUD.Modules;
using Blish_HUD.Modules.Managers;
using Microsoft.Xna.Framework;
using HybridUI.Core;

namespace HybridUI.BlishHUD
{
    public class HybridUIModule : Module
    {
        private readonly Logger _logger;

        public HybridUIModule(ModuleParameters moduleParameters) : base(moduleParameters)
        {
            _logger = Logger.GetLogger<HybridUIModule>();
        }

        protected override void Initialize()
        {
            _logger.Info("Hybrid UI Module initializing...");
            HybridUI.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            // Update Hybrid UI animations
            AnimationManager.Update((float)gameTime.ElapsedGameTime.TotalSeconds);
        }

        protected override void Unload()
        {
            _logger.Info("Hybrid UI Module unloaded.");
        }
    }
}
